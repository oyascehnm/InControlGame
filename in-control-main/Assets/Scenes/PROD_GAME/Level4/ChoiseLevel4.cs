using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoiseLevel4 : MonoBehaviour
{
    public GameObject fKeyUI;
    public GameObject decisionPanel;
    private bool isNearArea = false;
    private bool panelOpened = false;

    [Header("Ses Ayarları")]
    public AudioSource interactionAudioSource;

    private void Start()
    {
        fKeyUI.SetActive(false);
        decisionPanel.SetActive(false);
    }

    private void Update()
    {
        if (isNearArea && Input.GetKeyDown(KeyCode.F))
        {
            fKeyUI.SetActive(false);
            decisionPanel.SetActive(true);
            panelOpened = true;

            if (interactionAudioSource != null)
            {
                interactionAudioSource.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !panelOpened)
        {
            fKeyUI.SetActive(true);
            isNearArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (fKeyUI != null)
                fKeyUI.SetActive(false);

            isNearArea = false;
        }
    }

    public void OnPesEtClicked()
    {
        Debug.Log("Pes ettin! Ana menüye dönülüyor...");
        SceneManager.LoadScene("Level5_Acceptance");
    }

    public void OnDevamEtClicked()
    {
        Debug.Log("Devam ediyorsun!");
        SceneManager.LoadScene("Level5_Acceptance");
    }
}
