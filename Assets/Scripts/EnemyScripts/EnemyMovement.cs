using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // [SerializeField]
    // private float shotDelay = 100;

    [SerializeField]
    private float arrowSpeed = 10;

    [SerializeField]
    private float reloadTimer = 0.5f;

    [SerializeField]
    private float range = 10f;

    private float lastFire;

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

        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5f);
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
