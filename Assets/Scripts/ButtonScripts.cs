using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Close game when esc is pressed
        {
            Application.Quit(); // works in built product but on play mode
            UnityEditor.EditorApplication.isPlaying = false; // closes play mode
        }
    }
}
