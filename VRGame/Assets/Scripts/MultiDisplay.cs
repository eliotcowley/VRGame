using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMesh;

    // Use this for initialization
    void Start()
    {
        string displayMessage = "Displays connected: " + Display.displays.Length;
        Debug.Log(displayMessage);
        textMesh.SetText(displayMessage);

        if (Display.displays.Length > 1)
        {
            Display.displays[1].Activate();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
