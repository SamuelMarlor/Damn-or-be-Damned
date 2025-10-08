using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensitivity = 500f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //locking the cursor to the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {
        //getting the mouse inputs
        float mouseX= Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotation around the x axis (look up and down)
        xRotation -= mouseY;

        //clamp the rotation
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        //rotation around the y axis (look left and right)
        yRotation += mouseX;

        //apply rotations
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

    }
}
