using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private Rigidbody objectHit;
    private string sceneName;
    
    void Start()
    {
        objectHit = GetComponent<Rigidbody>();
        sceneName = SceneManager.GetActiveScene().name;
        
    }

    void OnTriggerEnter(Collider obj) 
    { 
        print(obj);
        print(sceneName);
        if (obj.gameObject.name == "Raven" && objectHit.name == "Goal")
        {
             SceneManager.LoadScene("Odin");
        }
        if (obj.gameObject.name == "Raven" && objectHit.name == "Goal2")
        {
            SceneManager.LoadScene("Outro");
        }
        if (obj.gameObject.name == "Raven" && objectHit.name == "Restart Wall" || obj.gameObject.name == "Raven" && objectHit.name == "Start Wall" || obj.gameObject.name == "Raven" && objectHit.name == "Ceiling" || obj.gameObject.name == "Raven" && objectHit.name == "Right Wall" || obj.gameObject.name == "Raven" && objectHit.name == "Left Wall" || obj.gameObject.name == "Raven" && objectHit.name == "Floor")
        {
           SceneManager.LoadScene(sceneName);
        }    
        if (obj.gameObject.name == "Arrow" && objectHit.name == "Raven")
        {
            HealthController.health -= 1;
        }    
    }  
}