using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float rotSpeed = 4.0f;
    public GameObject target;
    private float targetDistance;
    public float minAngle = -90.0f;
    public float maxAngle = 0.0f;
    private float rotateX;
    private bool isRotate = false;

    void Start()
    {
        targetDistance = Vector3.Distance(transform.position, target.transform.position);
    }

    void Update()
    {   
        if(Input.GetMouseButtonDown(1))
        {
            // print("Right click");
            isRotate = true;
        }
        if (Input.GetMouseButtonUp(1)){
            isRotate = false;
            print("Right click");
        }
        if(isRotate == true)
        {
            float y = Input.GetAxis("Mouse X") * rotSpeed;
            rotateX += Input.GetAxis("Mouse Y") * rotSpeed;
            rotateX = Mathf.Clamp(rotateX, minAngle, maxAngle);
            transform.eulerAngles = new Vector3(-rotateX, transform.eulerAngles.y + y, 0);
            transform.position = target.transform.position - (transform.forward * targetDistance);
        }
    }
}
