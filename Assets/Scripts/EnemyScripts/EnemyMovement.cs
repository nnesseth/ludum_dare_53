using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float shotDelay = 5;

    [SerializeField]
    private float arrowSpeed;

    [SerializeField]
    private float enemySpeed;

    public GameObject arrow;

    public Transform target;
    public Transform ArrowSpawner;

    void Start()
    {
        
    }

    void Update()
    {
         transform.LookAt(target);
         ShootArrow();
    }

    void ShootArrow()
    {
        arrowSpeed -= Time.deltaTime;

        // if (arrowSpeed > 0) return;

        arrowSpeed = shotDelay;

        GameObject arrowObj = Instantiate(arrow, ArrowSpawner.transform.position, ArrowSpawner.transform.rotation) as GameObject;
        Rigidbody arrowBody = arrowObj.GetComponent<Rigidbody>();
        print(arrowBody);
        arrowBody.AddForce(arrowSpeed * enemySpeed * Time.deltaTime * transform.forward);
        Destroy(arrowObj, 0.1f);
    }
}
