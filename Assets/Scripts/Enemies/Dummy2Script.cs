using System.Collections;
using UnityEngine;

public class Dummy2Script : MonoBehaviour
{
    private Animator animator;
    private bool isPlayerNear = false;
    private string stateName = "isNear";

    public bool ikActive = false;
    public Transform rightHandObj = null;
    public Transform leftHandObj = null;
    public Transform lookObj = null;

    // Start is called before the first frame update
    void Start()
    {
        if (TryGetComponent(out animator))
        {
            Debug.Log("Dummy found animator!");
        }
        ikActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isPlayerNear)
        {
            isPlayerNear = true;
            Debug.Log("Player near dummy 2!");
            animator.SetBool(stateName, true);
            ikActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && isPlayerNear)
        {
            isPlayerNear = false;
            Debug.Log("Player NOT near dummy 2!");
            animator.SetBool(stateName, false);
            ikActive = false;
        }
    }

    //Скопировал из методы

    void OnAnimatorIK()
    {
        if (animator)
        {
            //Если, мы включили IK, устанавливаем позицию и вращение
            if (ikActive)
            {
                // Устанавливаем цель взгляда для головы
                if (lookObj != null)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookObj.position);
                }
                // Устанавливаем цель для правой руки и выставляем её в позицию
                if (rightHandObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation); 
                }
                if (leftHandObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
                    animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandObj.rotation);
                }
            }
            else
            {
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetLookAtWeight(0);
            }
        }
    }
}
