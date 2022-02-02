using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClick : MonoBehaviour
{
    public void PlayAudio (AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
