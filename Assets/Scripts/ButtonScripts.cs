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
    int sceneIndex;

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
        // SceneManager.LoadScene("PauseMenu");
        SceneManager.LoadSceneAsync("PauseMenu", LoadSceneMode.Additive);
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(sceneIndex);
        
        
        isPaused = true;
        capturedScene = x;
        Pause(capturedScene);
    }
    public void ResumeButton(string x)
    {
        // SceneManager.LoadScene("MovementTest");
        SceneManager.UnloadSceneAsync("PauseMenu");
        isPaused = false;
        capturedScene = x;
        Pause(capturedScene);
    }

    public void Pause(string x)
    {   
        if (isPaused && x != "PauseMenu")
        {
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
            // realTime = Time.realtimeSinceStartup; //! Still working on buttoncd stuff to get pause to work more smoothly
            // buttonCd -= realTime;
            // Debug.Log(buttonCd + " " + realTime);
            Scene currentScene = SceneManager.GetSceneByName ("PauseMenu");
            Debug.Log(currentScene.name);
            if (currentScene.name != "PauseMenu")
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