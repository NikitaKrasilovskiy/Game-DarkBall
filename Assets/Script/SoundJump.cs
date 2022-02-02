using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundJump : MonoBehaviour
{
    public AudioSource JumpAudio;
    private void OnCollisionEnter(Collision collision)
    {
        JumpAudio.Play();
    }
}
