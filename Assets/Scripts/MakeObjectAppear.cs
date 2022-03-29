using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObjectAppear : MonoBehaviour
{
    public GameObject newObj; // set these in the Inspector to prefabs
    public float distance;
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
        //Vector3 pos = new Vector3(0f, position, 0f);
        //this.gameObject.transform.position = pos;

        if (Input.GetKeyDown("a"))
        {
            //Instantiate(newObj, pos, Quaternion.identity);
            Instantiate(newObj, transform.position + (transform.up * distance), transform.rotation);
        }
    }
}
