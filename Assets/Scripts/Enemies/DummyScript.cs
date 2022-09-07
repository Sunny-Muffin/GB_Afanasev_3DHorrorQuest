using System.Collections;
using UnityEngine;

public class DummyScript : MonoBehaviour
{
    private Animator animator;
    private bool isPlayerNear = false;
    private string stateName = "isNear";


    // Start is called before the first frame update
    void Start()
    {
        if (TryGetComponent(out animator))
        {
            Debug.Log("Dummy found animator!");
        }
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
            Debug.Log("Player near dummy!");
            transform.LookAt(other.transform);
            StartCoroutine(PlayAnim());
        }
    }

    IEnumerator PlayAnim()
    {
        animator.SetBool(stateName, true);
        yield return new WaitForSeconds (2);
        animator.enabled = false;
        Debug.Log("Coroutine finished");
    }
}
