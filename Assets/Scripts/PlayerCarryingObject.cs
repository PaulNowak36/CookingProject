using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarryingObject : MonoBehaviour
{
    private GameObject playerArmature;
    GameObject childObj;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerArmature = GameObject.Find("PlayerArmature");
        animator = playerArmature.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("e"))
        //{
        //    if (animator.GetBool("Carrying") == false)
        //    {
                

        //    }
        //}
    }

    public void getObject(GameObject objectCarried)
    {
        if (animator.GetBool("Carrying") && childObj == null)
        {
            childObj = Instantiate(objectCarried, transform.position, transform.rotation);
            childObj.transform.SetParent(transform);
            childObj.transform.localPosition = new Vector3();
        }
    }

    public GameObject giveObject()
    {
        return childObj;
        //childObj = null;
    }

    //public void releaseObject(GameObject objectReleased)
    //{
    //    if (animator.GetBool("Carrying") == false)
    //    {
    //        objectReleased = null;
    //    }
    //}

}
