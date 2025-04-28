using UnityEngine;

public class CursorController : MonoBehaviour
{
    void Start()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

    }
}

