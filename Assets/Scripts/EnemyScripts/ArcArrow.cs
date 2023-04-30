using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcArrow : MonoBehaviour
{
    public GameObject arrow;
    public Vector3 rotation = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        arrow.transform.Rotate(rotation);    
    }
}
