using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleInteractScript : MonoBehaviour
{
    //This variables is for checking if we can interact with an object
    public bool canInteract;
    //This variable is for checking if we are currently interacting with an object
    public bool isInteracting;

    //This variable is for keeping track of what object we are looking at !
    private Collider InteractableObject;

    //this variable is for keeping track of what key we are assigning to be our interact button
    public KeyCode interactKeyCode;

    ///<summary>
    /// This built in method is responsible for checking the moment the trigger
    /// collider comes in contact with another collider
    /// </summary>
    //private void OnTriggerEnter(Collider other)
    //{
    //    //Assing the Interactable Object Variable to the collision parameter variable
    //    InteractableObject = other;

    //    //If other game object has the same tag as Interactable
    //    if (other.gameObject.CompareTag("Interactable"))
    //    {
    //        //set can interact variable to be true
    //        canInteract = true;
    //    }
    //    else
    //    {            
    //        //set can interact variable to be false
    //        canInteract = false;
    //    }
    //}
    
    ////Called when the trigger collider stays in contact with another collider
    //private void OnTriggerStay(Collider other)
    //{
    //    //Assing the Interactable Object Variable to the collision parameter variable
    //    InteractableObject = other;

    //    //If other game object has the same tag as Interactable
    //    if (other.gameObject.CompareTag("Interactable"))
    //    {
    //        //set can interact variable to be true
    //        canInteract = true;
    //    }
    //    else
    //    {
    //        //set can interact variable to be false
    //        canInteract = false;
    //    }
    //}

    ////Called when the trigger collider leaves contact with another collider
    //private void OnTriggerExit(Collider other)
    //{
    //    //set can interact variable to be false
    //    canInteract = false;
    //}

    private void Update()
    {
        //Calls the DrawDetector method
        DrawDetector();
        //Create a var variable and set it to equal Interactable Object variable and do .GetComponent of The interface for interaction
        var Obj = InteractableObject.GetComponent<SampleIInteractable>();

        if (Input.GetKeyDown(interactKeyCode) && canInteract)
        {
            isInteracting = true;
            if (isInteracting)
            {
                Obj.Interact();
                isInteracting = false;  
            }

        }
    }

    public void DrawDetector()
    {
        Ray detector = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(detector, out RaycastHit hit, 200f))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.yellow);
            print("I HIT : " + hit.collider.name);

            InteractableObject = hit.collider;

            if (hit.collider.gameObject.CompareTag("Interactable"))
            {
                canInteract = true;
            }
            else
            {
                canInteract = false;
            }
        }
    }

}
