using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Intro");
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
        Application.Quit();
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1;
        PauseController.isPaused = false;
    }
}