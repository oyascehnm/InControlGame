using UnityEngine;
using UnityEngine.SceneManagement;

public class PotionInteraction : MonoBehaviour
{
    public GameObject ePressUI;
    public GameObject choicePanel;
    private bool playerNearby = false;

    [Header("Sonraki Sahne Ayarı")]
    public string nextLevel = "Level4_Depression";

    [Header("Ses Ayarları")]
    public AudioSource interactionAudioSource;

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            ePressUI.SetActive(false);
            choicePanel.SetActive(true);

            if (interactionAudioSource != null)
            {
                interactionAudioSource.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ePressUI.SetActive(true);
            playerNearby = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ePressUI.SetActive(false);
            playerNearby = false;
            choicePanel.SetActive(false);
        }
    }

    public void KendinIc()
    {
        Debug.Log("Kendine iksir içirdi!");
        choicePanel.SetActive(false);

        if (!string.IsNullOrEmpty(nextLevel))
        {
            SceneManager.LoadScene(nextLevel);
        }
        else
        {
            Debug.LogError("Next Level Name boş! Sahne adı yazman lazım!");
        }
    }

    public void BayginaIcir()
    {
        Debug.Log("Baygına iksir içirdi!");
        choicePanel.SetActive(false);

        if (!string.IsNullOrEmpty(nextLevel))
        {
            SceneManager.LoadScene(nextLevel);
        }
        else
        {
            Debug.LogError("Next Level Name boş! Sahne adı yazman lazım!");
        }
    }
}
