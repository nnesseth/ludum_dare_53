using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("movementTestScene"); // Add scenes to build settings to work
    }

}
