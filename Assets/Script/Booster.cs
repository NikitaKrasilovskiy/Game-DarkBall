using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public float force;
    public AudioSource BoosterAudio;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody playerRb;
        if (other.CompareTag("Player"))
        {
            playerRb = other.GetComponentInParent<Rigidbody>();
            playerRb.AddForce(transform.up * force);
            BoosterAudio.Play();
        }
    }
}