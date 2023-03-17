using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroMovement : MonoBehaviour
{
    public float velocity = 5f; // movement speed
    public float jumpStrength = 5f; // how high
    private bool onFloor = true;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody heroRb;

    void Start()
    {
        heroRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // left right
        forwardInput = Input.GetAxis("Vertical"); // forward backward

        //Time.deltaTime updates over time to compensate for different machine speeds
        transform.Translate(Vector3.forward * Time.deltaTime * velocity * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * velocity * horizontalInput);

        // Jump logic
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            heroRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            onFloor = false; // Impulse adds instant force.
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            onFloor = true;
        }
    }    
}
