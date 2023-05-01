using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaires : MonoBehaviour
{
    [SerializeField]
    private float inLeft, inRight, inTop, inBottom;

    public static float leftSide = -100.0f;
    public static float rightSide = 100.0f;
    public static float topSide = 20f;
    public static float bottomSide = 2.0f;


    void Update()
    {
        inLeft = leftSide;
        inRight = rightSide;
        inTop = topSide;
        inBottom = bottomSide;
    }
}
