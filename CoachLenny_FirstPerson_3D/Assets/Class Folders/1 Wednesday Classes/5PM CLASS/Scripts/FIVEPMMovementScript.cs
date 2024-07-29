using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVEPMMovementScript : MonoBehaviour
{
    //Variable that controls our speed
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //If I press the W key
        if (Input.GetKey(KeyCode.W))
        {
            //Move my player forward at a speed of 10f by the second
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        //If I press the A key
        //If I press the D key

        //If I press the S key
        if (Input.GetKey(KeyCode.S))
        {

        }

        /// Challenge
        /// Create key inputs for all four directions
        /// Use the example code above to recreate the movement and remember: 

        
    }
}
