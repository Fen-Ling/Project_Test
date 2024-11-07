using TMPro;
using UnityEngine;

public class GameHistory_State : MonoBehaviour
{
    public GameObject GameHistoryUI;
    public Main_Menu_State mainMenuState;
    public TextMeshProUGUI HistoryText; // UI элемент для отображения истории очков
    private string history = ""; // Переменная для хранения истории очков

    private void Start()
    {
        history = " \n"; // Инициализация заголовка
        UpdateHistoryUI();
    }
    private void OnEnable()
    {
        GameHistoryUI.SetActive(true);
    }
    private void OnDisable()
    {
        if (GameHistoryUI)
        {
            GameHistoryUI.SetActive(false);
        }
    }
    public void BackToMainMenu()
    {
        gameObject.SetActive(false);
        mainMenuState.gameObject.SetActive(true);
    }
    public void AddScore(int score)
    {
        history += $"Очки: {score}\n"; // Добавление новой строки с очками
        UpdateHistoryUI();
    }

    private void UpdateHistoryUI()
    {
        HistoryText.text = history; // Обновление текста UI
    }
}