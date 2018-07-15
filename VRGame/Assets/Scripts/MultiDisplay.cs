using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDisplay : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Debug.Log("Displays connected: " + Display.displays.Length);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
