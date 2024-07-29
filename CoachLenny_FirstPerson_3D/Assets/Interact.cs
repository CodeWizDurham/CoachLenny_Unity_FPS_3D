using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    public bool canInteract;
    public bool isInteracting;


    private Collider InteractableObject;

    public KeyCode InteractKey;

    public void DrawDetector()
    {
        Ray detector = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(detector, out RaycastHit hit))
        {

        }
    }







    // Update is called once per frame
    void Update()
    {
        
    }
}
