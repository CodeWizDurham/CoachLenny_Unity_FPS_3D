using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleDoorScript : MonoBehaviour, SampleIInteractable
{
    public Animator animator;
    void SampleIInteractable.Interact()
    {
        animator.SetTrigger("Interact");
        print("TRIGGER FIRED!!!");
    }

}
