using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroMovement : MonoBehaviour
{
    [SerializeField]
    public float speedIncrease = 0.1f;
    [SerializeField]
    public float maxSpeed = 200f;
    [SerializeField]
    public float rotationSpeed = 10f;
    [SerializeField]
    public float lift = 135f;

    private float speed;
    private float roll;
    private float pitch;
    private float yaw;

    Rigidbody birdRb;

    private float responseModifier {
        get {
            return (birdRb.mass / 10f) * rotationSpeed; 
        }
    }

    private void Awake() {
        birdRb = GetComponent<Rigidbody>();
    }

    private void HandleInputs()
    {
        roll = Input.GetAxis("Roll");
        pitch = Input.GetAxis("Pitch");
        yaw = Input.GetAxis("Yaw");

        if(Input.GetKey(KeyCode.Space))
        {
            speed += speedIncrease;
        }
        else if(Input.GetKey(KeyCode.LeftControl))
        {
            speed -= speedIncrease;
        }
        speed = Mathf.Clamp(speed, 0f, 100f);
    }

    private void Update() {
        HandleInputs();
    }

    private void FixedUpdate() {
        birdRb.AddForce(transform.right * speed);
        birdRb.AddTorque(transform.up * yaw * rotationSpeed);
        birdRb.AddTorque(transform.right * pitch * rotationSpeed);
        birdRb.AddTorque(-transform.forward * roll * rotationSpeed);
        // birdRb.AddForce(Vector3.up * birdRb.velocity.magnitude * lift);

    }
}