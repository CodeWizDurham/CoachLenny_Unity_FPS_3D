using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleBasicMovementScript : MonoBehaviour
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
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }

        //If I press the S key
        if (Input.GetKey(KeyCode.S))
        {
            //Move my player backward at a speed of 10f by the second
            transform.Translate(transform.forward * -1 * speed * Time.deltaTime);
        }

        //If I press the D key
        if (Input.GetKey(KeyCode.D))
        {
            //Move my player right at a speed of 10f by the second
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        //If I press the A key
        if (Input.GetKey(KeyCode.A))
        {
            //Move my player left at a speed of 10f by the second
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }


        /// Challenge
        /// Create key inputs for all four directions
        /// Use the example code above to recreate the movement and remember: 
        /// Positive is: right, up, and forward
        /// Negavtive is: left, down, and backwards

    }
}
