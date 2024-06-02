using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleInteractScript : MonoBehaviour
{
    //Variables for checking if we can interact with an object
    public bool canInteract;
    //Variable for checking if we are currently interacting with an object
    public bool isInteracting;

    //Variable for keeping track of what object we are looking at !
    private Collider InteractableObject;

    //Variable for keeping track of what key we are assigning to be our interact button
    public KeyCode interactKeyCode;

    //The moment
    private void OnTriggerEnter(Collider other)
    {
        InteractableObject = other;
        if (other.gameObject.CompareTag("Interactable"))
        {
            canInteract = true;
        }
        else
        {
            canInteract = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Interactable"))
        {
            canInteract = true;
        }
        else
        {
            canInteract = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canInteract = false;
    }

    private void Update()
    {
        DrawDetector();

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
