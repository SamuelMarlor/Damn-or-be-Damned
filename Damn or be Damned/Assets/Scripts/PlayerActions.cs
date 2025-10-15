using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro UseText;
    [SerializeField]
    private Transform Camera;
    [SerializeField]
    private float MaxUseDistance = 5f;
    [SerializeField]
    private LayerMask UseLayers;

    public void OnUse()
    {
        if (Physics.Raycast(Camera.position, Camera.forward, out RaycastHit hit, MaxUseDistance, UseLayers))
        {
            if (hit.collider.TryGetComponent<Door>(out Door door))
            { 
                if (door.IsOpen)
                {
                    door.Close();
                }
                else
                {
                    door.Open(transform.position);
                }
            }
        }
    }
        private void Update()
    {
        if (Physics.Raycast(Camera.position, Camera.forward, out RaycastHit hit, MaxUseDistance, UseLayers) 
            && hit.collider.TryGetComponent<Door>(out Door door))
        {
            if (door.isDoor)
            {
                if (door.IsOpen)
                {
                    UseText.SetText("Close \"E\"");
                }
                else
                {
                    UseText.SetText("Open \"E\"");
                }
                
            }
            if (!door.isDoor)
            { 
                if (!door.isFinal)
                {
                    if (door.isSave)
                    {
                        UseText.SetText("Save");
                    }
                    if (!door.isSave)
                    {
                        UseText.SetText("Damn");
                    }
                }
                if (door.isFinal)
                {
                    UseText.SetText("SEE YOUR FATE SEE YOUR FATE SEE YOUR FATE");
                }
            }
            UseText.gameObject.SetActive(true);
            UseText.transform.position = hit.point - (hit.point - Camera.position).normalized * 0.5f;
            UseText.transform.rotation = Quaternion.LookRotation((hit.point - Camera.position).normalized);
        }
        else
        {
            UseText.gameObject.SetActive(false);
        }
    }
}
