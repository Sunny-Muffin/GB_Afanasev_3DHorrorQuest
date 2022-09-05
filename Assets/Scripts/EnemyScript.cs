using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Animator animator;
    private int state = 0;
    private string stateName = "GrishaAnimParam";


    // Start is called before the first frame update
    void Start()
    {
        if (TryGetComponent(out animator))
        {
            Debug.Log("Found animator!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player entered!");
            state = 1;
            transform.LookAt(other.transform);
            animator.SetInteger(stateName, state);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player exited!");
            state = 0;
            animator.SetInteger(stateName, state);
        }
    }
}
