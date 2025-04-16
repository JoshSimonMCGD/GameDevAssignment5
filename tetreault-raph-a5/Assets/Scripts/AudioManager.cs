using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip Lazer;
    public AudioClip Death;
    public AudioClip MeteorBreak;

    public void PlaySFX(AudioClip clip)
    {
        
    }
}
