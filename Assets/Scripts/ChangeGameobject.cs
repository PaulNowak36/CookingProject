using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameobject : MonoBehaviour
{
    public GameObject firstObj; // set these in the Inspector to prefabs

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {            
            Destroy(this.gameObject);
            Instantiate(firstObj, transform.position, Quaternion.identity);
        }
    }
}
