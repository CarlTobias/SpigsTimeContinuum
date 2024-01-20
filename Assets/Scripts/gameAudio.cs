using UnityEngine;

public class gameAudio : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource SFX;

    public AudioClip bg;
    public AudioClip explode;
    public AudioClip spigDeath;

    // Start is called before the first frame update
    void Start()
    {
        music.clip = bg;
        music.Play();
    }

    public void playSFX(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }
}
