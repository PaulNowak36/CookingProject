using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInteracting : MonoBehaviour
{

    public Animator objectAnimated;
    public Animator player;

    public GameObject objectCarried;
    GameObject objectUsing;

    private Transform objectArea;

    public PlayerCarryingObject playerGetObject;

    // Start is called before the first frame update
    void Start()
    {
        objectArea = transform.parent.Find("ObjectAppear");
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
                if (objectAnimated.GetBool("Collectable Food") == false && player.GetBool("Carrying") == true )
                {                    
                    

                    GameObject objectType = playerGetObject.giveObject();
                    if (objectType?.GetComponent<Ingredient>().type == IngredientType.Tomato)
                    {
                        objectAnimated.SetBool("Food being cut", true);
                        player.SetBool("Carrying", false);
                        useObject(objectType);
                        Invoke("StopCuttingFood", 3.0f);
                    }
                    

                    
                }

                else if (objectAnimated.GetBool("Collectable Food") == true && player.GetBool("Carrying") == false)
                {
                    Destroy(objectUsing);
                    objectAnimated.SetBool("Collectable Food", false);
                    player.SetBool("Carrying", true);
                    playerGetObject.getObject(objectCarried);
                }
            }
            if (gameObject.tag == "Trash")
            {              
                player.SetBool("Carrying", false);
                Debug.Log("Thrown to the Trash");
                Destroy(playerGetObject.giveObject());
            }

            if (gameObject.tag == "Stove")
            {
                if (objectAnimated.GetBool("Collectable Steak") == false && player.GetBool("Carrying") == true)
                {
                    GameObject steakType = playerGetObject.giveObject();
                    if (steakType?.GetComponent<Ingredient>().type == IngredientType.Steak)
                    {
                        objectAnimated.SetBool("Steak is frying", true);
                        player.SetBool("Carrying", false);
                        useObject(steakType);
                        Invoke("StopFryingSteak", 10.0f);
                    }
                }

                else if (objectAnimated.GetBool("Collectable Steak") == true && player.GetBool("Carrying") == false)
                {
                    Destroy(objectUsing);
                    objectAnimated.SetBool("Collectable Steak", false);
                    objectAnimated.SetBool("Pan turned", false);
                    player.SetBool("Carrying", true);
                    playerGetObject.getObject(objectCarried);
                }
            }
        }   
    }

    private void StopCuttingFood()
    {
        replaceObject(objectUsing);
        objectAnimated.SetBool("Food being cut", false);
        objectAnimated.SetBool("Raised Knife", false);
        objectAnimated.SetBool("Collectable Food", true);
    }

    private void StopFryingSteak()
    {
        replaceObject(objectUsing);
        objectAnimated.SetBool("Steak is frying", false);
        objectAnimated.SetBool("Collectable Steak", true);
    }

    public void useObject(GameObject objectTaken)
    {
        if (player.GetBool("Carrying") == false && objectUsing == null && objectTaken != null)
        {
            Debug.Log("We use an object");
            objectUsing = objectTaken;
            objectUsing.transform.SetParent(objectArea);
            objectUsing.transform.localPosition = new Vector3();
        }
    }

    public void replaceObject(GameObject objectSwitched)
    {
        Debug.Log("We switch an object with another");
        Destroy(objectSwitched);
        objectUsing = Instantiate(objectCarried);
        objectUsing.transform.SetParent(objectArea);
        objectUsing.transform.localPosition = new Vector3();
    }
}
