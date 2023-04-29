using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdStats : MonoBehaviour
{
    void OnTriggerEnter(Collider obj) 
    { 

        if (obj.gameObject.name == "Bird")
        {
             SceneManager.LoadScene("Credits");
        }        
    }  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
