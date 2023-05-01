using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthController : MonoBehaviour
{
    [SerializeField]
    private GameObject ravenOne, ravenTwo, ravenThree, ravenOutOne, ravenOutTwo, ravenOutThree;

    [SerializeField]
    public static int health;

    void Start()
    {
        health = 3;
        ravenOne.gameObject.SetActive(true);
        ravenTwo.gameObject.SetActive(true);
        ravenThree.gameObject.SetActive(true);
        ravenOutOne.gameObject.SetActive(false);
        ravenOutOne.gameObject.SetActive(false);
        ravenOutOne.gameObject.SetActive(false);

    }
    void Update()
    {
        switch (health)
        {
            case 3:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(true);
                ravenThree.gameObject.SetActive(true);
                ravenOutOne.gameObject.SetActive(false);
                ravenOutTwo.gameObject.SetActive(false);
                ravenOutThree.gameObject.SetActive(false);
                break;
            case 2:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(true);
                ravenThree.gameObject.SetActive(false);
                ravenOutOne.gameObject.SetActive(false);
                ravenOutTwo.gameObject.SetActive(false);
                ravenOutThree.gameObject.SetActive(true);
                break;
            case 1:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(false);
                ravenThree.gameObject.SetActive(false);
                ravenOutOne.gameObject.SetActive(false);
                ravenOutTwo.gameObject.SetActive(true);
                ravenOutThree.gameObject.SetActive(true);
                break;
            case 0:
                ravenOne.gameObject.SetActive(false);
                ravenTwo.gameObject.SetActive(false);
                ravenThree.gameObject.SetActive(false);
                ravenOutOne.gameObject.SetActive(true);
                ravenOutTwo.gameObject.SetActive(true);
                ravenOutThree.gameObject.SetActive(true);
                SceneManager.LoadScene("Credits");
                break;
        }
    }
}
