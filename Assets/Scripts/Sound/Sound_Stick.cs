using UnityEngine;
namespace Golf
{
    public class Sound_Stick : MonoBehaviour
    {
        public AudioClip stickHitSound; // Звук удара клюшки
        private AudioSource hitAudioSource;
        [Range(0f, 1f)]
        public float volume = 1f; // Громкость удара клюшки
        void Start()
        {
            hitAudioSource = gameObject.AddComponent<AudioSource>();
            hitAudioSource.clip = stickHitSound; // Устанавливаем звук удара клюшки
            hitAudioSource.volume = volume; // Устанавливаем громкость
        }
        public void PlayHitSound()
        {
            hitAudioSource.clip = stickHitSound; // Удар клюшки
            hitAudioSource.Play();
        }
        public void SetVolume(float newVolume)
        {
            volume = newVolume; // Обновляем переменную громкости
            hitAudioSource.volume = volume; // Обновляем громкость AudioSource
        }
    }
}