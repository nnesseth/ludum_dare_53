using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public float velocity = 5f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // left right
        forwardInput = Input.GetAxis("Vertical"); // forward backward

        //Time.deltaTime updates over time to compensate for different machine speeds
        transform.Translate(Vector3.forward * Time.deltaTime * velocity * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * velocity * horizontalInput);
    }
}
