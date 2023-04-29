using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaires : MonoBehaviour
{
    [SerializeField]
    private float inLeft, inRight, inTop, inBottom;

    public static float leftSide = -9.3f;
    public static float rightSide = 9.3f;
    public static float topSide = 8.5f;
    public static float bottomSide = 2.0f;


    void Update()
    {
        inLeft = leftSide;
        inRight = rightSide;
        inTop = topSide;
        inBottom = bottomSide;
    }
}
