using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Implementing the interface means we have to call on the custom methods that were made in it!
public class SampleBookShelfScript : MonoBehaviour, SampleIInteractable
{
    /// <summary>
    /// This variable is a reference variable. This references the SamplePickUpScript
    /// allowing us access to all public variables and methods in this script.
    /// </summary>
    public SamplePickUpScript pickUpScript;

    //This variable stores a GameObject
    public GameObject Object;

    //This variable stores a transform that can be used to place things
    public Transform Location;

    //This is the contents of the custom method
    void SampleIInteractable.Interact()
    {
        //Calls on custom method PlaceThisObject
        PlaceThisObject();
    }

    //Custom Method responsible for placing down items
    public void PlaceThisObject()
    {
        //Sets public variable PickedUp to false
        pickUpScript.PickedUp = false;

        //Set the Object position to the location position
        Object.transform.position = Location.position;
    }
}
