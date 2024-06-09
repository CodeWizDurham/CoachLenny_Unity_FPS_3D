using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// RequireComponent is a attribute that will immediatley add the component required for this script
/// when applied to a game object
/// </summary>
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SamplePlayerObjectScript))]
public class SampleMovementScript : MonoBehaviour
{
    //This variable stores the data for the Rigidbody component, allowing game physics
    private Rigidbody physics;

    /// <summary>
    /// This variable is a reference variable. This references the SamplePlayerObjectScript
    /// allowing us access to all public variables and methods in this script.
    /// 
    /// [SerializeField] is a attribute! This attribute allows a private variable 
    /// to be seen in the Unity Inspector.
    /// </summary>
    [SerializeField]
    private SamplePlayerObjectScript Player;

    //This variable stores information for the exact Axis the player will move on, exp: "Horizontal" or "Vertical Axises"
    private Vector3 MovementInput; 

    //This variable stores information for the exact direction the player will move in
    private Vector3 MoveDirection;

    //This variable stores the value for the speed of the player
    private float speed;

    //The awake is used to set variables before the game starts
    private void Awake()
    {
        physics = GetComponent<Rigidbody>();
        Player = GetComponent<SamplePlayerObjectScript>();
    }

    //This is a custom method created to hold the body of coded needed for player movement
    public void MovementMethod()
    {
        //Set the speed variable of the movement script to equal the Player MovementSpeed Variable 
        speed = Player.MovementSpeed;
        //Assign Movement Input variable too access both HORIZONTAL and VERTICAL axis in a new Vector3
        MovementInput = new Vector3(Input.GetAxis("Horizontal"), physics.velocity.y, Input.GetAxis("Vertical"));

        //Use Move Direction variable to assign the transform direction based on the input, and multiply it by the speed
        MoveDirection = transform.TransformDirection(MovementInput) * speed;

        //Create a brand new velocity that uses the MoveDirection variable to acces the x and x movement
        physics.velocity = new Vector3(MoveDirection.x, physics.velocity.y, MoveDirection.z);
    }
    
    //Fixed Update is mainly used for physics based procedures
    private void FixedUpdate()
    {
        //Place movement method in here
        MovementMethod();
    }


}
