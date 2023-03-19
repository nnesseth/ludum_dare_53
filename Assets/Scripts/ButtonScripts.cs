using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{



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
}