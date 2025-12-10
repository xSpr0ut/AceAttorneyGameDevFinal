using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    TextArchitect architect;

    public AudioSource clickSource;
    public AudioClip click;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickSource.PlayOneShot(click);
        }

    }
}
