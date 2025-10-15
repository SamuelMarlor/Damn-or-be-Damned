using UnityEngine;

public class PlayerMoralityScript : MonoBehaviour
{
    public int MoralityCount = 50; // Class-level variable

    public void RegisterChoice(bool save)
    {
        if (save)
        {
            Debug.Log("Player chose to save.");
            MoralityCount += 10;
            Debug.Log(MoralityCount);
        }
        else
        {
            Debug.Log("Player chose to damn.");
            MoralityCount -= 10;
            Debug.Log(MoralityCount);
        }
    }
}