using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOver, ravenOne, ravenTwo, ravenThree, noRaven;

    [SerializeField]
    public static int health;


    void Start()
    {
        health = 3;
        ravenOne.gameObject.SetActive(true);
        ravenTwo.gameObject.SetActive(true);
        ravenThree.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 3:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(true);
                ravenThree.gameObject.SetActive(true);
                gameOver.gameObject.SetActive(true); 
                break;
            case 2:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(true);
                ravenThree.gameObject.SetActive(true);
                gameOver.gameObject.SetActive(false);
                break;
            case 1:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(true);
                ravenThree.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false);
                break;
            case 0:
                ravenOne.gameObject.SetActive(true);
                ravenTwo.gameObject.SetActive(false);
                ravenThree.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false); 
                break;
            default:
                ravenOne.gameObject.SetActive(false);
                ravenTwo.gameObject.SetActive(false);
                ravenThree.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true); 
                Time.timeScale = 0;
                break;
        }
    }
}
