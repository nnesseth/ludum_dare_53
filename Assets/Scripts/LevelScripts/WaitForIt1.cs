using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class WaitForIt1 : MonoBehaviour
{
    public float start;
    public float timeToWait = 32.0F;
    public bool enter = false;
    private VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            enter = true;
            player.Play();
        }

        if (enter && timeToWait < (Time.time - start))
        {
            SceneManager.LoadScene("Two");
        }
        
    }
}
