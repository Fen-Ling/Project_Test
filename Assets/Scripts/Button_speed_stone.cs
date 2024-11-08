using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{
    public class Button_speed_stone : MonoBehaviour
    {
        public InputField inputField; // Ссылка на InputField

        // Этот метод можно вызывать, когда пользователь готов сохранить введенные данные
        public void OnSubmit()
        {
            string inputValue = inputField.text; // Получаем текст из поля ввода

        }
    }
}