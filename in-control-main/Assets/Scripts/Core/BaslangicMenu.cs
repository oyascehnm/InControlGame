using UnityEngine;
using UnityEngine.SceneManagement;

public class BaslangicMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1"); // Buraya oyun sahnenin adýný yaz
    }

    public void QuitGame()
    {
        Debug.Log("Oyundan çýkýlýyor...");
        Application.Quit(); // Gerçek build'de çalýþýr, editörde çalýþmaz
    }
}
