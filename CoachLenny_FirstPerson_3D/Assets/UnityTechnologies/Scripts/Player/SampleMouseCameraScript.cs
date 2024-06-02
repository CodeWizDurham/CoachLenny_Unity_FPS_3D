using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMouseCameraCameraScript : MonoBehaviour
{
    /// <summary>
    /// This variable is a reference variable. This references the SamplePlayerObjectScript
    /// allowing us access to all public variables and methods in this script.
    /// </summary>
    public SamplePlayerObjectScript Player;

    //This variable stores data for the Main Camera
    public Camera PlayerCamera;

    //This variable stores the value for the speed of the camera
    private float Sensitivity;

    //This variable stores information for the exact Axis the camera will look on, exp: "Mouse X" or "Mouse Y" Axises
    private Vector3 MouseInput;

    //This variable stores information for the value of the X axis rotation of the camera
    private float MouseRotationX;

    private void Update()
    {
        //Assign Mouse Input variable too access both Mouse X and Mouse Y axis in a new Vector2
        MouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //Set the X Mouse Rotation to minus equal the Y axis of the Mouse Input multiplied by the Sensitivity
        MouseRotationX -= MouseInput.y * Sensitivity;

        MouseInput.y = Mathf.Clamp(MouseInput.y, 90f ,90f);

        transform.Rotate(0f, MouseInput.x * Sensitivity, 0f);

        PlayerCamera.transform.localRotation = Quaternion.Euler(MouseRotationX,0f,0f);

        Sensitivity = Player.MouseCameraSpeed();
        Cursor.visible = false;

    }
}
