using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// No instance created by a static class. Can only contain static members. Useful for single
// purpose methods that don't need a bunch of copies. Like calculating a square root.
public static class StaticClass
{
    // To get this method called outside this class, make it public.
    public static void HelloWurld()
    {
        Debug.Log("StaticClass.HelloWurld");
    }
}
