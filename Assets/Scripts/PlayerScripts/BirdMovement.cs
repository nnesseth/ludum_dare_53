using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    [SerializeField]
    private float strafeSpeed = 5;

    [SerializeField]
    private float speed = 5;

    private Vector3 dirInput;
    private Rigidbody birdBody;

     private void Awake()
     {
         TryGetComponent(out birdBody);
     }

    void FixedUpdate()
    {
        // transform.position += transform.forward * Time.deltaTime * speed;
        // transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

          dirInput = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
          birdBody.velocity = new Vector3(0, 0, speed * Time.deltaTime);
         
          birdBody.MovePosition(transform.position + dirInput * Time.deltaTime * speed);
        
        // if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        // { 
        //     transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed); 
        // }
        // if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        // {
        //     transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed * -1);
        // }
        // if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        // {
        //    transform.position += Vector3.up *  Time.deltaTime * strafeSpeed;
        // }
        // if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        // {
        //     transform.position += Vector3.down * Time.deltaTime * strafeSpeed;   
        // }
    }
}
