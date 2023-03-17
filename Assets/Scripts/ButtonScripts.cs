using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public static bool isPaused;
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
        SceneManager.LoadScene("StartScene");
    }
    public void PauseButton(string x)
    {
        SceneManager.LoadScene("PauseScene");
        isPaused = true;
        capturedScene = x;
        Pause(capturedScene);
    }
    public void ResumeButton()
    {
        SceneManager.LoadScene("movementTestScene");
        isPaused = false;
    }

    public void Pause(string x)
    {  
        if (isPaused && x != "PauseScene")
        {
            //! movement logic next
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            ResumeButton();
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