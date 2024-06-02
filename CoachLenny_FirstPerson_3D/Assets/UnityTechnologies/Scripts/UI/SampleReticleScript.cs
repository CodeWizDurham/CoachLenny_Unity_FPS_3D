using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleReticleScript : MonoBehaviour
{
    public SampleInteractScript ReferenceInteractScript;

    public Image MyReticleImage;

    private void Update()
    {
        if (ReferenceInteractScript.canInteract)
        {
            MyReticleImage.color = Color.green;
        }
        else
        {
            MyReticleImage.color = Color.white;
        }
    }

}
