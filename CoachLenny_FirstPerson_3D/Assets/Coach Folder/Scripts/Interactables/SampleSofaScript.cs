using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Implementing the interface means we have to call on the custom methods that were made in it!
public class SampleSofaScript : MonoBehaviour, SampleIInteractable
{
    //This variable stores a transform that can be used to place things
    public Transform SitAt;

    //This variable stores a GameObject
    public GameObject PlaceThisObject;

    /// <summary>
    /// This variable is a reference variable. This references the SampleMovementScript
    /// allowing us access to all public variables and methods in this script.
    /// </summary>
    public SampleMovementScript CancelThisScript;

    //This variable will be responsible for keeping track of the number of key presses
    private int presses = 0;

    //This is the contents of the custom method
    void SampleIInteractable.Interact()
    {
        //Calls the SitObjectDown method when it is activated
        SitObjectDown();

        //Create a print method to help keep track of the Interaction
        print("TRIGGER FIRED!!!");
    }

    //Custom method created for the player to sit down and get up
    public void SitObjectDown()
    {
        //if the key press count is 0
        if (presses == 0)
        {
            //Place the object in the location of the SitAt variable and set the transform.forward
            //to equal SitAt variables transform.forward
            PlaceThisObject.transform.position = SitAt.position;
            PlaceThisObject.transform.forward = SitAt.forward;

            //Disable the movement script so the player can't move while being seated
            CancelThisScript.enabled = false;
            print("SEATED!!!");

            //Add 1 press so the player can get up
            presses++;
        }
        //if the press is greater or equal to 1
        else if (presses >= 1)
        {
            //Set the press back to 0, and then set the Transform position of the player back to its original value
            presses = 0;
            PlaceThisObject.transform.position = PlaceThisObject.transform.position;
            PlaceThisObject.transform.forward = PlaceThisObject.transform.forward;

            //Enable the movement script so the player can't move while being seated
            CancelThisScript.enabled = true;
            print("UNSEATED!!!");
        }
    }

}
