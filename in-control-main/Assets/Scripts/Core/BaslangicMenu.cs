using UnityEngine;
using UnityEngine.SceneManagement;

public class BaslangicMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1"); // Buraya oyun sahnenin ad�n� yaz
    }

    public void QuitGame()
    {
        Debug.Log("Oyundan ��k�l�yor...");
        Application.Quit(); // Ger�ek build'de �al���r, edit�rde �al��maz
    }
}
