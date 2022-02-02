using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public Object destroy;

    private void OnTriggerEnter(Collider des)
    {
        if (des.CompareTag("Player"))
        {
            des.GetComponentInParent<Rigidbody>();
            Destroy(destroy);
        }
    }
}
