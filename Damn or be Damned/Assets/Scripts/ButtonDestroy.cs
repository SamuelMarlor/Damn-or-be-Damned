using System;
using System.Collections;
using UnityEngine;

public class ButtonDestroy : MonoBehaviour
{
    public void DestroyButton()
    {
        // Get this GameObject's tag dynamically
        string objectTag = gameObject.tag;

        // Find all objects with the same tag
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(objectTag);

        int pressedLayer = LayerMask.NameToLayer("Pressed");

        foreach (GameObject obj in taggedObjects)
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