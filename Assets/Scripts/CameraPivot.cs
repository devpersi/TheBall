using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    private float mouseSensitivity = 0.001f;

    private float rotationY;

    [SerializeField]
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationY += mouseX;
        rotationY = Mathf.Clamp(rotationY, -1, 1);
        
        transform.localEulerAngles += new Vector3(0, rotationY, 0);
        transform.position = target.position - transform.forward * 15;
        transform.position = transform.position - new Vector3(0, 9.5f, 0);

    }


}
