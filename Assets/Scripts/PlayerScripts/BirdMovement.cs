using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private float forwardMovement = 5;

    [SerializeField]
    private float strafeSpeed = 10;
    
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardMovement, Space.World);
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if (this.gameObject.transform.position.x > Boundaires.leftSide) 
            {

                transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed);
            }         
        }

        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (this.gameObject.transform.position.x < Boundaires.rightSide) 
            {
                transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed * -1);
            }
        }

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            if (this.gameObject.transform.position.y < Boundaires.topSide)
            {
                transform.position += Vector3.up *  Time.deltaTime * strafeSpeed;
            }
        }

        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            if (this.gameObject.transform.position.y > Boundaires.bottomSide)
            {
                transform.position += Vector3.down * Time.deltaTime * strafeSpeed;
            }
        }
    }
}
