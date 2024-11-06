using UnityEngine;

public class Sound_Stoun : MonoBehaviour
{
    public AudioClip stoneHitSound; // Звук удара об камень
    private AudioSource hitAudioSource;
    [Range(0f, 1f)]
    public float volume = 1f; // Громкость удара клюшки
    void Start()
    {
        hitAudioSource = gameObject.AddComponent<AudioSource>();
        hitAudioSource.clip = stoneHitSound; // Устанавливаем звук удара клюшки
        hitAudioSource.volume = volume; // Устанавливаем громкость
    }
    public void PlayStoneSound()
    {
        hitAudioSource.clip = stoneHitSound; // Удар об камень
        hitAudioSource.Play();
    }
    public void SetVolume(float newVolume)
    {
        volume = newVolume; // Обновляем переменную громкости
        hitAudioSource.volume = volume; // Обновляем громкость AudioSource
    }
}