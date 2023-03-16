using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    [SerializeField] private GameObject sun;
    private float zRotate = 0;
    [SerializeField] private float rotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zRotate = Time.deltaTime * rotationSpeed;
        sun.transform.Rotate(zRotate, 0, 0);
    }
}
