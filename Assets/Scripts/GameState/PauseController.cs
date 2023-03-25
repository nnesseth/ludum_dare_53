using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    //* This will go on the hero object

    public UnityEvent GamePaused;
    public UnityEvent GameResumed;

    public GameObject Player;





    private static bool isPaused;
    void Start()
    {
    }
    public void resumeClick()
    {
        Player = GameObject.FindWithTag("Player");
        Time.timeScale = 1;
        Player.GetComponent<PauseController>().GameResumed.Invoke();
        SceneManager.UnloadSceneAsync("PauseMenu");
        isPaused = false;
    }
    public void pause()
    {
        isPaused = !isPaused;
        Debug.Log(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;
            GamePaused.Invoke();
            SceneManager.LoadSceneAsync("PauseMenu", LoadSceneMode.Additive);
        }
        else
        {
            Time.timeScale = 1;
            GameResumed.Invoke();
            SceneManager.UnloadSceneAsync("PauseMenu");
        }
    }

    //* If we need to worry about animation this can be done using unscaled time.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }
}
