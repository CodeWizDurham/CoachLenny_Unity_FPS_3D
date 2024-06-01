using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleLampScript : MonoBehaviour, SampleIInteractable
{
    public GameObject LightSource;
    void SampleIInteractable.Interact()
    {
        LightSwitch();
        print("TRIGGER FIRED!!!");
    }

    void LightSwitch()
    {
        if(LightSource.active == false)
        {
            LightSource.SetActive(true);
        }
        else
        {
            LightSource.SetActive(false);
        }
    }
}
