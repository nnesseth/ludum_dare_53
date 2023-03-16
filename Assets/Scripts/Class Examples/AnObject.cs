using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

// An object that models a message
public class AnObject
{
    string message = string.Empty;

    // Default constructor
    public AnObject()
    {
        message = "AnObject.SayHello()";
    }

    // Overloaded constructor in case a message is specificed
    public AnObject(string message)
    {
        this.message = message;
    }

    public void SayHello()
    {
        Debug.Log(message);
    }
}
