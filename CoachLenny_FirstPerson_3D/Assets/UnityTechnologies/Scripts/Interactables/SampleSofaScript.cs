using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleSofaScript : MonoBehaviour, SampleIInteractable
{
    public Transform SitAt;
    public GameObject PlaceThisObject;

    public SampleMovementScript CancelThisScript;
    private int presses = 0;
    void SampleIInteractable.Interact()
    {
        print("TRIGGER FIRED!!!");
        

        if(presses == 0)
        {
            PlaceThisObject.transform.position = SitAt.position;
            PlaceThisObject.transform.forward = SitAt.forward;

            CancelThisScript.enabled = false;
            print("SEATED!!!");
            presses++;
        }
        else if (presses >= 1)
        {
            presses = 0;
            PlaceThisObject.transform.position = PlaceThisObject.transform.position;
            PlaceThisObject.transform.forward = PlaceThisObject.transform.forward;

            CancelThisScript.enabled = true;   
            print("UNSEATED!!!");
        }

    }

}
