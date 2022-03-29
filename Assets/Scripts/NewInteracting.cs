using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInteracting : MonoBehaviour
{

    public Animator objectAnimated;
    public Animator player;

    public GameObject objectCarried;

    public PlayerCarryingObject playerGetObject;

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
            if (gameObject.tag == "FoodContainer")
            {
                player.SetBool("Carrying", true);
                playerGetObject.getObject(objectCarried);
            }
            if (gameObject.tag == "CuttingBoard")
            {
                objectAnimated.SetBool("Food being cut", true);
                player.SetBool("Carrying", false);
            }
            if (gameObject.tag == "Trash")
            {              
                player.SetBool("Carrying", false);
            }        
        }
    }
}
