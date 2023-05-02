using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class WaitForIt2 : MonoBehaviour
{
    public float start;
    public float timeToWait = 32.0F;

    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToWait < (Time.time - start))
        {
            SceneManager.LoadScene("Credits");
        }
        
    }
}
