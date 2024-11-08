using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Golf
{
    public class Batton_Image : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        public Sprite normalSprite; // обычное изображение
        public Sprite pressedSprite; // изображение при нажатии
        private Image buttonImage; // компонент Image кнопки

        void Start()
        {
            buttonImage = GetComponent<Image>();
            buttonImage.sprite = normalSprite; // Убедитесь, что кнопка начинает с нормального изображения
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            buttonImage.sprite = pressedSprite; // Изменяем изображение на "нажато"
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            buttonImage.sprite = normalSprite; // Возвращаем изображение обратно
        }
    }
}
