using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Implementing the interface means we have to call on the custom methods that were made in it!
public class SamplePickUpScript : MonoBehaviour, SampleIInteractable
{
    //This variable stores a transform that can be used to place things
    public GameObject GoToLocation;

    //this variable stores true or false
    public bool PickedUp;

    //This is the contents of the custom method
    void SampleIInteractable.Interact()
    {
        //Set variable to true
        PickedUp = true;
    }

    private void Update()
    {
        //if pickedup is true
        if (PickedUp)
        {
            //Set this postion to the positon of the GoToLocation variable
            this.transform.position = GoToLocation.transform.position;
        }
    }
}
