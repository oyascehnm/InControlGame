using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerToSceneChange : MonoBehaviour
{
    public string targetSceneName = "Level2_Anger";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger'a girdin, sahne deðiþiyor: " + targetSceneName);
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
