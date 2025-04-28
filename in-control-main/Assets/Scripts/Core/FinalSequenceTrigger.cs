using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSequenceTrigger : MonoBehaviour
{
    [Header("Sonraki Sahne Adı")]
    public string nextSceneName = "credit";

    private bool hasTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true;
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
