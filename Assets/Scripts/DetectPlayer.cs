using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public Animator animator;
    public string boolName = "myBool";

    private GameObject StoveOn;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Stove")
        {
            StoveOn = transform.parent.Find("Red Light").gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (animator != null)
        {
            animator.SetBool(boolName, true);
        }
        

        if (gameObject.tag == "Stove")
        {
            StoveOn.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (animator != null)
        {
            animator.SetBool(boolName, false);
        }

        if (gameObject.tag == "Stove")
        {
            StoveOn.SetActive(false);
        }
    }
}
