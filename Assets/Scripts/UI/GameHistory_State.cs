using TMPro;
using UnityEngine;

namespace Golf
{
    public class GameHistory_State : MonoBehaviour
    {
        public GameObject GameHistoryUI;
        public Main_Menu_State mainMenuState;
        public TextMeshProUGUI HistoryText; // UI элемент для отображения истории очков
        private string history = ""; // Переменная для хранения истории очков

        private void Start()
        {
            LoadHistory();
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
            SaveHistory();
            UpdateHistoryUI();
        }
        private void UpdateHistoryUI()
        {
            HistoryText.text = history; // Обновление текста UI
        }

        // Метод для загрузки истории из PlayerPrefs
        private void LoadHistory()
        {
            history += PlayerPrefs.GetString("GameHistory"); // Загружает историю, если есть
        }

        // Метод для сохранения истории в PlayerPrefs
        private void SaveHistory()
        {
            PlayerPrefs.SetString("GameHistory", history); // Сохраняет историю
            PlayerPrefs.Save(); // Явно сохраняет изменения
        }
        public void ClearHistory()
    {
        history = ""; // Сбрасываем историю
        PlayerPrefs.DeleteKey("GameHistory"); // Удаляем сохраненную историю
        UpdateHistoryUI(); // Обновляем UI
    }

    }
}