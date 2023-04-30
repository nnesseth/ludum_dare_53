using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // [SerializeField]
    // private float shotDelay = 100;

    [SerializeField]
    public float arrowSpeed = 10;

    [SerializeField]
    public float reloadTimer = 0.5f;

    [SerializeField]
    public float range = 10f;

    public float lastFire;

    public GameObject arrow;
    public Transform target;
    public Transform ArrowSpawner;
    public Vector3 moveDirection;

    void Start()
    {
        
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= range && Time.time - lastFire >= reloadTimer)
        {
            ShootArrow();
            lastFire = Time.time;
        }

        Vector3 direction = transform.position - target.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 25f);
    }

    void ShootArrow()
    {

        var arrowObj = Instantiate(arrow, transform.position, transform.rotation);
        // arrowObj.Velocity = Vector3.forward * arrowSpeed;
        arrowObj.GetComponent<Rigidbody>().velocity = Vector3.forward * arrowSpeed; 
        print("Arrow Speed "+arrowSpeed);
        print("ArrowSpawner.forward "+ArrowSpawner.forward);
    }
}
