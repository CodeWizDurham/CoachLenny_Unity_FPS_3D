using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.EventSystems;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SamplePlayerObjectScript))]
public class SampleMovementScript : MonoBehaviour
{
    // Start is called before the first frame update\
    private Rigidbody physics;

    [SerializeField]
    private SamplePlayerObjectScript Player;

    //Variables for input/keybind movement
    private Vector3 MovementInput; 
    private Vector3 MoveDirection;
    private float speed;

    private void Awake()
    {
        physics = GetComponent<Rigidbody>();
        Player = GetComponent<SamplePlayerObjectScript>();
    }

    public void MovementMethod()
    {
        //Set the speed variable of the movement script to equal the Player MovementSpeed Variable 
        speed = Player.MovementSpeed;
        //Assign Movement Input variable too access both HORIZONTAL and VERTICAL axis
        MovementInput = new Vector3(Input.GetAxis("Horizontal"), physics.velocity.y, Input.GetAxis("Vertical"));

        //Use Move Direction variable to assign the transform direction based on the input, and multiply it by the speed
        MoveDirection = transform.TransformDirection(MovementInput) * speed;

        //Create a brand new velocity that uses the MoveDirection variable to acces the x and x movement
        physics.velocity = new Vector3(MoveDirection.x, physics.velocity.y, MoveDirection.z);
    }

    private void FixedUpdate()
    {
        MovementMethod();
    }


}
