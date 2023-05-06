using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    [SerializeField]
    private float strafeSpeed = 20000;

    [SerializeField]
    private float speed = 2000000;

    [SerializeField]
    ForceMode mode;

    Rigidbody birdRb;

     private void Awake()
     {
         birdRb = GetComponent<Rigidbody>();
     }

    void FixedUpdate()
    {
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
    }
}
