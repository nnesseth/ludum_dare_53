using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class WaitForIt : MonoBehaviour
{
    public float start;
    public float timeToWait = 32.0F;
    private bool skip;

    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
        skip = false;
    }

    // Update is called once per frame
    void Update()
    {        
        // If player wants to skip, set skip flag
        if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.Return))
        {
            skip = true;
        }

        if (skip == true || (timeToWait < (Time.time - start)))
        {
            skip = false;
            SceneManager.LoadScene("One");
        }
        
    }
}
