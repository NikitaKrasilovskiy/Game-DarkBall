using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelTime : MonoBehaviour
{
    public Object delt;
    public float time;

    private void OnTriggerEnter(Collider des)
    {
        if (des.CompareTag("Player"))
        {
            des.GetComponentInParent<Rigidbody>();
            Destroy(delt, time);
        }
    }
}