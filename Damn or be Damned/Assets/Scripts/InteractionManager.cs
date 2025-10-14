using System;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public float interactionDistance = 3f;
    public LayerMask interactableLayer = 6;
    public Transform playerCamera;

    private IInteractable _currentInteractable;

    void Update()
    {
        CheckForInteractable();

        if(_currentInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            _currentInteractable.Interact();
        }
    }

    private void CheckForInteractable()
    {
        Ray ray = new Ray(playerCamera.position, playerCamera.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance, interactableLayer))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                if (_currentInteractable != interactable)
                {
                    //ResetOutLine();
                    _currentInteractable = interactable;


                }
                
            }
        }
        
    }
    //private void ResetOutLine();
}
