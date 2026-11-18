using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel; // Ссылка на нашу панель

    // Открыть настройки
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    // Закрыть настройки
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}