using System;
using System.Collections;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    public bool isPressed = false;
    public bool Save = true;
    private ButtonDestroy buttonDestroy;
    private PlayerMoralityScript playerMorality;

    void Start()
    {
        buttonDestroy = GetComponentInChildren<ButtonDestroy>();
        GameObject Morality = GameObject.FindWithTag("Morality");
        if (Morality != null)
        {
            playerMorality = Morality.GetComponent<PlayerMoralityScript>();
        }
        else
        {
            Debug.LogWarning("Morality GameObject not found!");
        }
    }

    public void Interact()
    {
        Debug.Log("Interact called");
        StartCoroutine(ButtonPressed());
    }

    private IEnumerator ButtonPressed()
    {
        Debug.Log("Button Pressed");
        isPressed = true;
        Debug.Log(isPressed);
        gameObject.layer = LayerMask.NameToLayer("Pressed");

        if (playerMorality != null)
        {
            playerMorality.RegisterChoice(Save);
        }

        if (Save)
        {
            Debug.Log("Player Chose To Save");
        }
        if (!Save)
        {
            Debug.Log("Player Chose To Damn");
        }

        if (buttonDestroy != null)
        {
            buttonDestroy.DestroyButton();
        }
        else
        {
            Debug.LogWarning("ButtonDestroy component not found!");
        }
        yield return null;
    }
}