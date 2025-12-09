using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    TextArchitect architect;

    public AudioSource clickSource;
    public AudioClip click;

    public AudioSource typeSource;
    public AudioClip type;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickSource.PlayOneShot(click);
        }

    }
}
