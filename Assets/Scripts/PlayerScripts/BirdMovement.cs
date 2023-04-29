using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private float forwardMovement = 5;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardMovement, Space.World);
    }


}
