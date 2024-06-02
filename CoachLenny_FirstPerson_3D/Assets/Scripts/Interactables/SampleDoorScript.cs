using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Implementing the interface means we have to call on the custom methods that were made in it!
public class SampleDoorScript : MonoBehaviour, SampleIInteractable
{
    //This variable stores an Animator, for animations
    public Animator animator;

    //This is the contents of the custom method
    void SampleIInteractable.Interact()
    {
        //Activate the animation created, the door opeing or closing
        animator.SetTrigger("Interact");

        //Create a print method to help keep track of the Interaction
        print("TRIGGER FIRED!!!");
    }

}
