using System;
using System.Collections;
using UnityEngine;

public class ButtonDestroy : MonoBehaviour
{
    public void DestroyButton()
    {
        GameObject[] roomObjects = GameObject.FindGameObjectsWithTag("Room1");
        int pressedLayer = LayerMask.NameToLayer("Pressed");

        foreach (GameObject obj in roomObjects)
        {
            // Set parent object's layer to "Pressed" if it has a parent
            if (obj.transform.parent != null)
            {
                obj.transform.parent.gameObject.layer = pressedLayer;
            }
            // Destroy the object
            Destroy(obj);
        }
    }
}