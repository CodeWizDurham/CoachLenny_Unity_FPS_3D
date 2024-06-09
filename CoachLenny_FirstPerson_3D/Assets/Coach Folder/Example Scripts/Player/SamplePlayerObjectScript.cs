using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayerObjectScript : MonoBehaviour
{
    //This variable stores our string/name information, exp string: "Penelope"
    public string myName;

    //This variable stores our number value for our speed exp: 5f
    [Range(1f,10f)]
    public float MovementSpeed;

    //This variable stores our number value for our Sensitivity exp: -2f
    public float MouseSensitivity;

    //This is a custom method that we created to return the myName value
    public string Name()
    {
        //returns myName, exp: My name is "Penelope"
        return myName;
    }

    //This is a custom method that we created to return the MovementSpeed value
    public float Speed()
    {
        //returns MovementSpeed, exp: speed of 5f
        return MovementSpeed;
    }

    //This is a custom method that we created to return the MovementSpeed value
    public float MouseCameraSpeed()
    {
        //returns MouseSensitivity, exp: sensitivity of -2f
        return MouseSensitivity;
    }


}
