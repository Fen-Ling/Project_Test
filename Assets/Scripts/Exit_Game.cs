using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Exit_Game : MonoBehaviour

    {
        // Этот метод будет вызываться при нажатии на кнопку
        public void Quit()
        {
#if UNITY_EDITOR
            // Если мы в редакторе Unity, прекращаем воспроизведение
            UnityEditor.EditorApplication.isPlaying = false;
#else
            // В противном случае, выходим из приложения
            Application.Quit();
#endif
        }
    }
}
