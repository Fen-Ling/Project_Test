using UnityEngine;
namespace Golf
{
    public class Sound_World : MonoBehaviour
    {
        public AudioClip worldSound; // Звук мира (например, фоновая музыка)
        private AudioSource worldAudioSource;
        [Range(0f, 1f)]
        public float volume = 1f; // Громкость звука

        void Start()
        {
            worldAudioSource = gameObject.AddComponent<AudioSource>();
            worldAudioSource.clip = worldSound; // Устанавливаем звук мира
            worldAudioSource.loop = true; // Зацикливаем фоновую музыку
            worldAudioSource.volume = volume; // Устанавливаем громкость
            worldAudioSource.Play(); // Запускаем звук мира
        }
        public void SetVolume(float newVolume)
        {
            volume = newVolume; // Обновляем переменную громкости
            worldAudioSource.volume = volume; // Обновляем громкость AudioSource
        }
    }
}