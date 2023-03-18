using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public static bool isPaused;

    float realTime;
    float buttonCd = 10;

    string sceneName;
    string capturedScene;

    public void StartButton()
    {
        SceneManager.LoadScene("MovementTest"); // Add scenes to build settings to work
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
    public void ExitButton()
    {
        Application.Quit(); // works in built product but on play mode
        UnityEditor.EditorApplication.isPlaying = false; // closes play mode
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void PauseButton(string x)
    {
        SceneManager.LoadScene("PauseMenu");
        isPaused = true;
        capturedScene = x;
        Pause(capturedScene);
    }
    public void ResumeButton(string x)
    {
        SceneManager.LoadScene("MovementTest");
        isPaused = false;
        capturedScene = x;
        Pause(capturedScene);
    }

    public void Pause(string x)
    {   
        if (isPaused && x != "PauseMenu")
        {
            //! movement logic next
            //! needs to pause not reset
            Time.timeScale = 0f;
           
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) // Pause game when esc is pressed
        {  
            realTime = Time.realtimeSinceStartup;
            buttonCd -= realTime;
            Debug.Log(buttonCd + " " + realTime);
            Scene currentScene = SceneManager.GetActiveScene ();
            sceneName = currentScene.name;
            Debug.Log(sceneName);
            if (sceneName != "PauseMenu" && sceneName != "StartMenu" )
            {
                PauseButton(sceneName);
            }
            else if (sceneName == "StartMenu")
            {
                return;
            }
            else
            {
                ResumeButton(sceneName);

            }
          
        }
    }
}