using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayerObjectScript : MonoBehaviour
{
    public string myName;
    [Range(1f,10f)]
    public float MovementSpeed;

    private float MouseSensitivityX;
    private float MouseSensitivityY;
    public string Name()
    {
        return myName;
    }

    public float Speed()
    {
        return MovementSpeed;
    }

    public float MouseRotatationX()
    {
        return MouseSensitivityX;
    }

    public float MouseRotatationY()
    {
        return MouseSensitivityY;
    }

}
