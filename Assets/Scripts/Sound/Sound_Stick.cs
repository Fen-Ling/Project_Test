using UnityEngine;

public class Sound_Stick : MonoBehaviour
{
    public AudioClip stickHitSound; // Звук удара клюшки
    private AudioSource hitAudioSource;
    void Start()
    {
        hitAudioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayHitSound()
    {
        hitAudioSource.clip = stickHitSound; // Удар клюшки
        hitAudioSource.Play();
    }
}