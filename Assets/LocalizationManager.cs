using UnityEngine;
using TMPro;

public class LocalizationManager : MonoBehaviour
{
    [Header("Тексты кнопок")]
    public TextMeshProUGUI playText;
    public TextMeshProUGUI settingsText;
    public TextMeshProUGUI quitText;

    private bool isRussian = true; // Флаг текущего языка

    public void SwitchLanguage()
    {
        isRussian = !isRussian; // Меняем флаг на противоположный

        if (isRussian)
        {
            playText.text = "ИГРАТЬ";
            settingsText.text = "НАСТРОЙКИ";
            quitText.text = "ВЫЙТИ";
        }
        else
        {
            playText.text = "  PLAY";
            settingsText.text = "  SETTINGS";
            quitText.text = "  QUIT";
        }
    }
}