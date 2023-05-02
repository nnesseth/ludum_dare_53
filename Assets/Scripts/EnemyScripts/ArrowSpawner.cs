using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public float arrowSpeed = 10;
    public float reloadTimer = 0.5f;
    public float range = 10f;
    public float lastFire;

    public GameObject arrow;
    public Transform target;
    public Vector3 moveDirection;
    private Vector3 force;
    private ForceMode forceMode;
    public float thrust = 20f;

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
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 25f);
    }

    void ShootArrow()
    {
        force = transform.forward * thrust;
        forceMode = ForceMode.Impulse;
        var arrowObj = Instantiate(arrow, transform.position, transform.rotation);
        arrowObj.GetComponent<Rigidbody>().AddForce(force, forceMode);
        // Destroy(arrowObj, 5);
    }
}