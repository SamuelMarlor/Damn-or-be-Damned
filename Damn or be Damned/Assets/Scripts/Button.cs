using System;
using System.Collections;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    public bool isPressed = false;
    public bool Correct = true;
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
            playerMorality.RegisterChoice(Correct);
        }

        if (Correct)
        {
            Debug.Log("Player Chose Correctly");
        }
        if (!Correct)
        {
            Debug.Log("Player Chose Incorrectly");
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