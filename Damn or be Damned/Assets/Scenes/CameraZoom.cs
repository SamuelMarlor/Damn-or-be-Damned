using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    private float zoomFOV;
    [SerializeField]
    private float normalFOV;
    [SerializeField]
    private float zoomSpeed;

    private Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float targetFOV;

        if (Input.GetKey(KeyCode.Mouse1))
        {
            targetFOV = zoomFOV;
        }
        else
        {
            targetFOV = normalFOV;
        }
        
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, targetFOV, Time.deltaTime * zoomSpeed);
    }
}
