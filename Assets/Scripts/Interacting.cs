using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{
    public Animator animator;
    public string trueBool = "myTrueBool";
    public string falseBool = "myFalseBool";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            animator.SetBool(trueBool, true);
            animator.SetBool(falseBool, false);
        }
    }
}
