using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneReset : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Raven" && rb.name == "Level Bounding Box Left")
        {
            Debug.Log("Left.");
            SceneManager.LoadScene(4);
        }
        if(collision.gameObject.name == "Raven" && rb.name == "Level Bounding Box Right")
        {
            Debug.Log("Right");
            SceneManager.LoadScene(4);
        }
        if (collision.gameObject.name == "Raven" && rb.name == "Level Bounding Box Front")
        {
            Debug.Log("Front");
            SceneManager.LoadScene(4);
        }
        if(collision.gameObject.name == "Raven" && rb.name == "Level Bounding Box Rear")
        {
            Debug.Log("Rear");
            SceneManager.LoadScene(4);
        }
    }
}
