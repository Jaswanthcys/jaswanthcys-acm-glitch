
using UnityEngine;

public class SoundManager : MonoBehaviour  //done
{
    public static SoundManager instance;   // global access

    public AudioSource audioSource;        // speaker
    public AudioClip flapSound;            // flap sound
    public AudioClip scoreSound;           // score sound
    public AudioClip hitSound;             // hit sound
    public AudioClip gameOverSound;        // game over sound
    public AudioClip backgroundMusic;

    void Awake()
    {
        // make sure only ONE sound manager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // keep between scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // play sound even if game is paused
        audioSource.ignoreListenerPause = true;
    }

    public void PlayFlap()
    {
        audioSource.PlayOneShot(flapSound);
    }

    public void PlayScore()
    {
        audioSource.PlayOneShot(scoreSound);
    }

    public void PlayHit()
    {
        audioSource.PlayOneShot(hitSound);
    }

    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
    public void ResetSound()
    {
        audioSource.Stop();
        audioSource.time = 0f;
    }
    public void PlayBackground()
    {
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;
        audioSource.time = 0f;
        audioSource.Play();
    }

    public void StopBackground()
    {
        audioSource.Stop();
        
    }   
}
