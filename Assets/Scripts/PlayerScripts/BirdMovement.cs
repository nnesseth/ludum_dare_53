using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    float thrust, thrustMultiplier, yawMultiplier, pitchMultiplier;

    new Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float pitch = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Horizontal");

        rigidbody.AddRelativeForce(0f, thrust * thrustMultiplier * Time.deltaTime, 0f);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
