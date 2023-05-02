using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    [SerializeField]
    private float strafeSpeed = 50;

    [SerializeField]
    private float speed = 50;

    
    void FixedUpdate()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        { 
            transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed); 
        }
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed * -1);
        }
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
           transform.position += Vector3.up *  Time.deltaTime * strafeSpeed;
        }
        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.position += Vector3.down * Time.deltaTime * strafeSpeed;   
        }
    }
}
