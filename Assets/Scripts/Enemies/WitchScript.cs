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
            Debug.Log("Witch has animator!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Debug.Log("w");
            animator.SetFloat("VelocityY", 1);
        }
        if (Input.GetKey("s"))
        {
            Debug.Log("s");
            animator.SetFloat("VelocityY", -1);
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("d");
            animator.SetFloat("VelocityX", 1);
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("a");
            animator.SetFloat("VelocityX", -1);
        }
    }
}
