using UnityEngine;

public class WitchScript : MonoBehaviour
{
    private Animator animator;
    private int state = 0;
    private string stateName = "GrishaAnimParam";


    // Start is called before the first frame update
    void Start()
    {
        if (TryGetComponent(out animator))
        {
            //Debug.Log("Witch has animator!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            //Debug.Log("w");
            animator.SetFloat("VelocityY", 1);
        }
        else if (Input.GetKey("s"))
        {
            //Debug.Log("s");
            animator.SetFloat("VelocityY", -1);
        }
        else if (Input.GetKey("d"))
        {
            //Debug.Log("d");
            animator.SetFloat("VelocityX", 1);
        }
        else if (Input.GetKey("a"))
        {
            //Debug.Log("a");
            animator.SetFloat("VelocityX", -1);
        }
        else
        {
            animator.SetFloat("VelocityX", 0);
            animator.SetFloat("VelocityY", 0);
        }
    }
}
