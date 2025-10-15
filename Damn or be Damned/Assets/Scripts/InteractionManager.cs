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

        if (_currentInteractable != null && Input.GetKeyDown(KeyCode.E))
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
                    
                    _currentInteractable = interactable;
                    StartCoroutine(ResetOutWithDelay(2f));
                    

                }

            }
        }
        
    }

    private System.Collections.IEnumerator ResetOutWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetOut();
    }

    private void ResetOut()
    {
        _currentInteractable = null;
    }
}
