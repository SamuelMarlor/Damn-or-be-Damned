using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalButtonScript : MonoBehaviour, IInteractable
{
    public bool isPressed = false;
    private PlayerMoralityScript playerMorality;

    void Start()
    {
        // Find the morality script
        GameObject moralityObj = GameObject.FindWithTag("Morality");
        if (moralityObj != null)
        {
            playerMorality = moralityObj.GetComponent<PlayerMoralityScript>();
        }
        else
        {
            Debug.LogWarning("Morality GameObject not found!");
        }
    }

    public void Interact()
    {
        if (playerMorality != null)
        {
            if (playerMorality.MoralityCount >= 50)
            {
                Debug.Log("Good event triggered");
                SceneManager.LoadSceneAsync(4);
                // Place your good event logic here
            }
            else
            {
                Debug.Log("Bad event triggered");
                SceneManager.LoadSceneAsync(5);
                // Place your bad event logic here
            }
        }
        else
        {
            Debug.LogWarning("PlayerMoralityScript not found!");
        }
    }

    private IEnumerator ButtonPressed()
    {
        Debug.Log("Button Pressed");
        isPressed = true;
        yield return null;
    }
}
