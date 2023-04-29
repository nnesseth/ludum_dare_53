using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private Rigidbody objectHit;
    void Start()
    {
        objectHit = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider obj) 
    { 
        if (obj.gameObject.name == "Bird" && objectHit.name == "Cube (8)")
        {
             SceneManager.LoadScene("Credits");
        }
        if (obj.gameObject.name == "Bird" && objectHit.name == "volcave")
        {
           SceneManager.LoadScene("testLevel");
        }        
    }  
}
