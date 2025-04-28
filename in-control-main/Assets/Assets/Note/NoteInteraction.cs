using UnityEngine;
using UnityEngine.UI;

public class NoteInteraction : MonoBehaviour
{
    public GameObject notePanel;   
    public Text noteText;           
    public string noteContent;      
    public GameObject fKeyText;
    public AudioSource zarfAudioSource;
    public GameObject doorToUnlock;

    private bool playerNearby = false; 
    private bool noteOpen = false;     
    private bool doorUnlocked = false;

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.F))
        {
            if (!noteOpen)
            {
                OpenNote();
            }
            else
            {
                CloseNote();
            }
        }
    }

    private void OpenNote()
    {
        fKeyText.SetActive(false);
        notePanel.SetActive(true);
        noteText.text = noteContent;
        noteOpen = true;

        if (zarfAudioSource != null)
            zarfAudioSource.Play();

        if (!doorUnlocked)
        {
            UnlockDoor();
            doorUnlocked = true;
        }

        if (GameManager.Instance != null)
            GameManager.Instance.hasReadNote = true;
    }

    private void CloseNote()
    {
        if (zarfAudioSource != null)
            zarfAudioSource.Play();

        notePanel.SetActive(false);
        noteOpen = false;
        fKeyText.SetActive(true);
    }

    private void UnlockDoor()
    {
        if (doorToUnlock != null)
        {
            doorToUnlock.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
            if (fKeyText != null)
                fKeyText.SetActive(true); 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            if (fKeyText != null)
                fKeyText.SetActive(false);

            if (noteOpen)
            {
                notePanel.SetActive(false);
                noteOpen = false;
            }
        }
    }
}