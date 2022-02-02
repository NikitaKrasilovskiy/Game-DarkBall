using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delit : MonoBehaviour
{
    public Object del;

    private void OnTriggerExit(Collider des)
    {
        if (des.CompareTag("Player"))
        {
            des.GetComponentInParent<Rigidbody>();
            Destroy(del);
        }
    }
}