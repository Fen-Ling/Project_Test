using UnityEngine;

public class Sound_Stoun : MonoBehaviour
{
    public AudioClip stoneHitSound; // Звук удара об камень
    private AudioSource hitAudioSource;
    void Start()
    {
        hitAudioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayStoneSound()
    {
        hitAudioSource.clip = stoneHitSound; // Удар об камень
        hitAudioSource.Play();
    }
}