using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private Rigidbody objectHit;
    public int health = 3;
    void Start()
    {
        objectHit = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider obj) 
    {
        print(objectHit.name);
        if (obj.gameObject.name == "Raven" && objectHit.name == "Cube (8)")
        {
             SceneManager.LoadScene("Credits");
        }
        if (obj.gameObject.name == "Raven" && objectHit.name == "volcave")
        {
           SceneManager.LoadScene("testLevel");
        }    
        if (obj.gameObject.name == "Arrow" && objectHit.name == "Raven")
        {
            health -= 1;
            print(health);
            if(health <= 0)
            {
                SceneManager.LoadScene("Credits");
            }
        }    
    }  
}