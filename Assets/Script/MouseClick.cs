using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public float force;
    private AudioSource AttackAudio;
    void Awake()
    {
        AttackAudio = GetComponent<AudioSource>();
    }
    void OnMouseOver()
    {
        Vector3 playerPosition = PlayerReference.instance.transform.position;
        Vector3 directionToPlayer = playerPosition - transform.position;
        directionToPlayer = directionToPlayer.normalized;

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().AddForce(directionToPlayer.normalized * force);
            GetComponent<Rigidbody>().useGravity = true;
            AttackAudio.Play();
        }
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody>().AddForce(-directionToPlayer.normalized * force);
            GetComponent<Rigidbody>().useGravity = true;
            AttackAudio.Play();
        }
    }
}
