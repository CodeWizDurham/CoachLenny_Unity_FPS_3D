using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMouseCameraCameraScript : MonoBehaviour
{

    public Camera PlayerCamera;
    [Range(1f,10f)]
    public float Sensitivity;

    private Vector3 MouseInput;
    private float MouseRotationX;

    private void Awake()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        MouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        MouseRotationX -= MouseInput.y * Sensitivity;
        MouseInput.y = Mathf.Clamp( MouseRotationX,90f ,90f);

        transform.Rotate(0f, MouseInput.x * Sensitivity, 0f);

        PlayerCamera.transform.localRotation = Quaternion.Euler(MouseRotationX,0f,0f);
    }
}
