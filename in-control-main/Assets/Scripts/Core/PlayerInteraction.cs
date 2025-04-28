using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private InteractableObject currentInteractable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (currentInteractable != null)
            {
                currentInteractable.Interact();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            currentInteractable = other.GetComponent<InteractableObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            if (currentInteractable != null && currentInteractable.gameObject == other.gameObject)
            {
                currentInteractable = null;
            }
        }
    }
}
