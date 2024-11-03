using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public class Stone_Destroy : MonoBehaviour
    {
        public delegate void StoneFellEventHandler(GameObject stone2);
        public event StoneFellEventHandler OnStoneFell;

        public Transform fallPoint; // Точка, ниже которой считается, что камень упал
        private int stoneCount = 0;

        private void Update()
        {
            if (transform.position.y < fallPoint.position.y) // Проверка на падение
            {
                OnStoneFell?.Invoke(gameObject);
                Destroy(gameObject); // Удаляем камень
            }
        }

        private void OnEnable()
        {
            FindObjectOfType<Stone_Destroy>().OnStoneFell += HandleStoneFell; // Подписываемся на событие
        }

        private void OnDisable()
        {
            FindObjectOfType<Stone_Destroy>().OnStoneFell -= HandleStoneFell; // Отписываемся от события
        }

        private void HandleStoneFell(GameObject stone2)
        {
            stoneCount++;

            if (stoneCount >= 3)
            {
                Destroy(stone2);
                stoneCount = 0; // Сбрасываем счётчик
            }
        }
    }
}



