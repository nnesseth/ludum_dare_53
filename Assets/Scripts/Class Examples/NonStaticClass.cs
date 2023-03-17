using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor.VersionControl;
using UnityEngine;

public class NonStaticClass : MonoBehaviour
{
    // A couple of objects
    AnObject anObject = new AnObject();
    AnObject anObjectWithAMessage = new AnObject("Called from AnObject.SayHello() using AnObjects overloaded constructor.");

    // Magic method, pulled by C++ and added to the list of scripts to run every frame.
    void Update()
    {
        // Normal listening
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Called from NonStaticClass Update() method.");
        }

        // Using a static method. No instance needed.
        if (Input.GetKeyDown(KeyCode.W))
        {
            StaticClass.HelloWurld();
        }

        // Using an object.
        // Note: Can't use the new keyword when extending MonoBehaviour. Says it wants to
        // use AddComponent() or ScriptableObject(). AddComponent() can be called on a gameobject. 
        // ScriptableObject(), in accordance with docs.unity3d.com is normally used for "Saving and
        // storing data during an Editor session" and "Saving data as an Asset in your Project to use
        // at run time". AnObject doesn't extend MonoBehaviour.
        if (Input.GetKeyDown(KeyCode.E))
        {
            anObject.SayHello();
            anObjectWithAMessage.SayHello();
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("Get out of my volcaveno!");
    }
}
