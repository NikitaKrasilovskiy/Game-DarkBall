using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform trans;
    public AudioSource Kill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponentInParent<Rigidbody>();
            other.transform.position = trans.transform.position;
            Kill.Play();
        }
    }
}