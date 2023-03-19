using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public static bool isPaused;

    public GameState CurrentGameState { get;}

    void Awake()
    {
        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }

    void OnDestroy() 
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

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
    public void PauseGame()
    {
        SceneManager.LoadSceneAsync("PauseMenu", LoadSceneMode.Additive);
    }
    public void ResumeButton()
    {
        SceneManager.UnloadSceneAsync("PauseMenu");
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState;
    }

    void Update()
    {
        Debug.Log(CurrentGameState);
        // if (CurrentGameState == GameState.Paused)
        // {
        //    PauseGame();
        // }
        // if (CurrentGameState == GameState.)
    }
}