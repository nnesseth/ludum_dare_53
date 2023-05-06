using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    [SerializeField]
    private float strafeSpeed = 20000;

    [SerializeField]
    private float speed = 10;

    [SerializeField]
    ForceMode mode;

    // private Vector3 dirInput;
    private Rigidbody birdBody;
    Rigidbody birdRb;

     private void Awake()
     {
         TryGetComponent(out birdBody);
         birdRb = GetComponent<Rigidbody>();
     }

    void FixedUpdate()
    {
          // birdBody.velocity = new Vector3(0, 0, speed * Time.deltaTime); 
          birdRb.AddForce(transform.forward * speed * Time.deltaTime);
          transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
          if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
          {
            birdRb.AddForce(transform.right * -strafeSpeed * Time.deltaTime);
          }
          if(Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
          {
            birdRb.AddForce(transform.right * strafeSpeed * Time.deltaTime);
          }
        //   if(Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        //   {
        //     birdRb.AddForce(transform.up * -strafeSpeed );
        //   }
        //   if(Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        //   {
        //     birdBody.velocity = new Vector3(0, speed * Time.deltaTime,  speed * Time.deltaTime);
        //   }
        //   if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)))
        //   {
        //     birdBody.velocity = new Vector3(-speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime); 
        //   }
        //   if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow)))
        //   {
        //     birdBody.velocity = new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime); 
        //   }
        //   if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)))
        //   {
        //     birdBody.velocity = new Vector3(speed * Time.deltaTime, -speed * Time.deltaTime, speed * Time.deltaTime); 
        //   }
        //   if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow)))
        //   {
        //     birdBody.velocity = new Vector3(-speed * Time.deltaTime, -speed * Time.deltaTime, speed * Time.deltaTime); 
        //   }         
    }
}
