using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKey : MonoBehaviour
{
    public Object destroy;

    private void OnTriggerEnter(Collider des)
    {
        if (des.CompareTag("Key"))
        {
            des.GetComponentInParent<Rigidbody>();
            Destroy(destroy);
        }
    }
}
