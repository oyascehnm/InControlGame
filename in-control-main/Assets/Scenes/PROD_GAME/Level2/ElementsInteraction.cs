using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ElementInteraction : MonoBehaviour
{
    public GameObject fKeyUI;
    private bool isNearElement = false;
    private string targetSceneName = "Level3_Bargaining";

    private void Start()
    {
        fKeyUI.SetActive(false);
    }

    private void Update()
    {
        if (isNearElement && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F'ye bastýn, sahne deðiþiyor: " + targetSceneName);
            SceneManager.LoadScene(targetSceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isNearElement = true;
            fKeyUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isNearElement = false;
            fKeyUI.SetActive(false);
        }
    }
}
