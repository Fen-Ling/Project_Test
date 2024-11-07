using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_State : MonoBehaviour
{
    public GameObject SetteingsUI;
    public Main_Menu_State mainMenuState;
    public Golf.LevelController levelController;
    public InputField inputField;
    private void OnEnable()
    {
        SetteingsUI.SetActive(true);
    }
    private void OnDisable()
    {
        if (SetteingsUI)
        {
            SetteingsUI.SetActive(false);
        }
    }
    public void BackToMainMenu()
    {
        gameObject.SetActive(false);
        mainMenuState.gameObject.SetActive(true);
    }

    public void ChangeDelay()
    {
        if (levelController != null && inputField != null)
        {
            float newDelay;

            // Попробуем преобразовать введенное значение в float
            if (float.TryParse(inputField.text, out newDelay))
            {
                levelController.SetDelay(newDelay); // Устанавливаем новое значение задержки
            }
            else
            {
                Debug.LogWarning("Введено некорректное значение! Пожалуйста, введите число.");
            }
        }
        
    }
    
}
