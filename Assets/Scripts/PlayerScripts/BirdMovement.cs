using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    [SerializeField]
    private float strafeSpeed = 20;

    [SerializeField]
    private float speed = 1500;

    private Vector3 dirInput;
    private Rigidbody birdBody;

     private void Awake()
     {
         TryGetComponent(out birdBody);
     }

    void FixedUpdate()
    {
        //   dirInput = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
          birdBody.velocity = new Vector3(0, 0, speed * Time.deltaTime); 
          if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
          {
            birdBody.velocity = new Vector3(-speed * Time.deltaTime, 0, 0); 
          }
          if(Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
          {
            birdBody.velocity = new Vector3(speed * Time.deltaTime, 0, 0); 
          }
        //   birdBody.MovePosition(transform.position + dirInput * Time.deltaTime * strafeSpeed);
    }
}
