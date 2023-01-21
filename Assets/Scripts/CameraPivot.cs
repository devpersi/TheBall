using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    private readonly float mouseSensitivity = 0.1f;

    private float rotationY;

    [SerializeField]
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        // Add mouse position on the X axis to rotationY 
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationY += mouseX;

        // Lock rotationY to slow, only 1 rotation distance unit per frame
        rotationY = Mathf.Clamp(rotationY, -1, 1);
        
        // Rotate and move the camera pivot object based on rotationY
        // The camera has a fixed position based on the camera pivot's position
        // so we get a rotating camera effect
        transform.localEulerAngles += new Vector3(0, rotationY, 0);

        // 
        transform.position = target.position - transform.forward * 15;
        transform.position = transform.position - new Vector3(0, 9.5f, 0);
    }
}
