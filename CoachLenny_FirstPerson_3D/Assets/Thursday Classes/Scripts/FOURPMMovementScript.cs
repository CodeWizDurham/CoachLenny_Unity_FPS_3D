using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOURPMMovementScript : MonoBehaviour
{
    //This variable is for our game physics
    public Rigidbody physics;

    private float speed;

    private FOURPMPlayerObjectScript player;

    private Vector3 MovementInput;

    private Vector3 MoveDirection;

    private void Awake()
    {
        physics = GetComponent<Rigidbody>();
    }
}
