using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoReset : MonoBehaviour
{
    [SerializeField] private GameObject raven;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(raven))
        {
            //Debug.Log("Reload scene two.");
            //SceneManager.LoadScene(8);
        }
    }
}
