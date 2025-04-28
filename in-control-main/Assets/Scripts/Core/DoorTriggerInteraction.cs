using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTriggerInteraction : MonoBehaviour
{
    public string sceneToLoad;
    public AudioSource doorSound;
    public float delayBeforeLoad = 1f;

    private bool triggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (triggered) return;

        if (collision.CompareTag("Player"))
        {
            if (GameManager.Instance != null && GameManager.Instance.hasReadNote)
            {
                triggered = true;

                if (doorSound != null)
                    doorSound.Play();

                Invoke(nameof(LoadNextScene), delayBeforeLoad);
            }
            else
            {
                Debug.Log("Kapı açılmadı çünkü not henüz okunmadı.");
            }
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
