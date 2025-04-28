using UnityEngine;
using UnityEngine.SceneManagement;

public class MapPortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Triggered Portal: " + gameObject.name);

            switch (gameObject.name)
            {
                case "Level1Trigger":
                    SceneManager.LoadScene("Level_Denial");
                    break;
                case "DenialTriggerUp":
                    SceneManager.LoadScene("Level_Anger");
                    break;
                case "DenialTriggerDown":
                    SceneManager.LoadScene("Level_Anger");
                    break;
                case "AngerTrigger":
                    SceneManager.LoadScene("Level_Bargaining");
                    break;
                case "DepressionTrigger":
                    SceneManager.LoadScene("Level_Acceptance");
                    break;
            }
        }

    }
}

