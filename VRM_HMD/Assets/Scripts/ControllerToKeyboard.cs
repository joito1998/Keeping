using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerToKeyboard : MonoBehaviour
{
    private TouchScreenKeyboard overlayKeyboard;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            overlayKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        }
    }
}
