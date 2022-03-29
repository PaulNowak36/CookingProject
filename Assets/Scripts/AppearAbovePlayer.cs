using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearAbovePlayer : MonoBehaviour
{
    public GameObject prefab; // set these in the Inspector to prefabs

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject childObj;
            
        if (Input.GetKeyDown("a"))
        {
            //Instantiate(newObj, pos, parentObj.identity);

            childObj = Instantiate(prefab, transform.position, transform.rotation);
            childObj.transform.SetParent(transform);
            childObj.transform.localPosition = new Vector3();

        }
    }
}
