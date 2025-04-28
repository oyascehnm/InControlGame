using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public void Interact()
    {
        Debug.Log("You interacted with " + gameObject.name);
        Destroy(gameObject);
    }
}
