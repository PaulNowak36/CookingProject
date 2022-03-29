using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public Animator animator;
    public string boolName = "myBool";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool(boolName, true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool(boolName, false);
    }
}
