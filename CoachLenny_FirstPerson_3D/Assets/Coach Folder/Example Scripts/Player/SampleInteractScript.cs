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
    //This can be public or private
    private Collider InteractableObject;

    //this variable is for keeping track of what key we are assigning to be our interact button
    public KeyCode interactKeyCode;

    //
    public float length;

    private void Update()
    {
        //Calls the DrawDetector method
        DrawDetector();
        //Create a var variable and set it to equal Interactable Object variable and do .GetComponent of The interface for interaction
        var Obj = InteractableObject.GetComponent<SampleIInteractable>();

        //If I press the Interact button DOWN and can interact with other objects
        if (Input.GetKeyDown(interactKeyCode) && canInteract)
        {
            //Set is interacting to be true
            //If I am interacting with an object the call on the IInteractable Interact Method
            //Set is interacting to be false
            isInteracting = true;
            if (isInteracting)
            {
                Obj.Interact();
                isInteracting = false;  
            }

        }
    }

    //A custom method created for detecting Interacatable objects
    public void DrawDetector()
    {
        //Create a Ray variable and have it start from the player, and facing forward
        Ray detector = new Ray(transform.position, transform.forward);

        //If my Raycast
        if (Physics.Raycast(detector, out RaycastHit hit, length))
        {
        //Set the Interactable object variable to equal the collider the Raycast "hit"
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

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.forward);
    }

}
