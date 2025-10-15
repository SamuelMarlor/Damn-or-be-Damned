using UnityEngine;

public class PlayerMoralityScript : MonoBehaviour
{
    public int MoralityCount = 50; // Class-level variable

    public void RegisterChoice(bool Answer)
    {
        if (Answer)
        {
            Debug.Log("Player chose Correct.");
            MoralityCount += 10;
            Debug.Log(MoralityCount);
        }
        else
        {
            Debug.Log("Player chose Incorrect.");
            MoralityCount -= 10;
            Debug.Log(MoralityCount);
        }
    }
}