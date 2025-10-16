using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDINGSCENES : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
