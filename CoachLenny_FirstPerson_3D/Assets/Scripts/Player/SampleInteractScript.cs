using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleInteractScript : MonoBehaviour
{
    public bool canInteract;
    public bool isInteracting;

    private Collider InteractableObject;
    public KeyCode interactKeyCode;
    
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

    private void OnTriggerExit(Collider other)
    {
        canInteract = false;
    }

    private void Update()
    {
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

}
