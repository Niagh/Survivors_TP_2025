using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip menuMusic;
    public AudioClip gameplayMusic;
    public AudioClip enemyHitSFX;

    private static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    void Start()
    {
        PlayMenuMusic();
    }

    public void PlayMenuMusic()
    {
        musicSource.clip = menuMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayGameplayMusic()
    {
        musicSource.clip = gameplayMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayHitSFX()
    {
        AudioSource.PlayClipAtPoint(enemyHitSFX, Camera.main.transform.position);
    }
}