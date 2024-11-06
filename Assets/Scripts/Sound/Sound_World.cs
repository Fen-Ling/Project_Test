using UnityEngine;

public class Sound_World : MonoBehaviour
{
    public AudioClip worldSound; // Звук мира (например, фоновая музыка)
    private AudioSource worldAudioSource;

    void Start()
    {
        worldAudioSource = gameObject.AddComponent<AudioSource>();
        worldAudioSource.clip = worldSound; // Устанавливаем звук мира
        worldAudioSource.loop = true; // Зацикливаем фоновую музыку
        worldAudioSource.Play(); // Запускаем звук мира
    }
}