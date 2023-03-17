using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public static bool isPaused;
    string sceneName;
    string resumeScene;

    public void StartButton()
    {
        SceneManager.LoadScene("movementTestScene"); // Add scenes to build settings to work
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void ExitButton()
    {
        Application.Quit(); // works in built product but on play mode
        UnityEditor.EditorApplication.isPlaying = false; // closes play mode
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("StartScene");
    }
    //! Need to create a resume button and restart button
    public void PauseButton(string x)
    {
        SceneManager.LoadScene("PauseScene");
        isPaused = true;
        Debug.Log(x + " is paused");
        Pause();
    }
    public void ResumeButton()
    {
        SceneManager.LoadScene("movementTestScene");
        isPaused = false;
        Debug.Log(isPaused);
        Pause();
    }

    public void Pause(string x)
    {  
        if (isPaused)
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
        if (Input.GetKeyDown(KeyCode.Escape)) // Pause game when esc is pressed
        {
            Scene currentScene = SceneManager.GetActiveScene ();
            sceneName = currentScene.name;
            PauseButton(sceneName);
        }
    }
}