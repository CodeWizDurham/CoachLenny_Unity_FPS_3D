using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THREEPMMouseCameraScript : MonoBehaviour
{

    //This variable stores data for the Main Camera
    public Camera PlayerCamera;

    //This variable stores the value for the speed of the camera
    private float Sensitivity;

    //This variable stores information for the exact Axis the camera will look on, exp: "Mouse X" or "Mouse Y" Axises
    private Vector2 MouseInput;

    //This variable stores information for the value of the X axis rotation of the camera
    private float MouseRotationX;

    // Update is called once per frame
    void Update()
    {
        //Assign Mouse Input variable too access both Mouse X and Mouse Y axis in a new Vector2


        //Set the X Mouse Rotation to minus equal the Y axis of the Mouse Input multiplied by the Sensitivity


        ///Set the Y of the MouseInput to equal Mathf.Clamp(). within the parameter place the MouseRotationX
        ///and place the min and max value to limit the camera rotation


        ///Set the rotation of the transform to include the MouseInput multiplied by the Sensitivity in the Y column
        ///leave the X, and Z at 0


        ///Set the Player Camera's local rotation to equal Quaternion.Euler()
        ///In the parameters besure to leave the Y, and Z column at 0 and add the Mouse Rotation X variable to the X column


        //Constantly have the visiblity of the cursor to be false;
       
    }
}
