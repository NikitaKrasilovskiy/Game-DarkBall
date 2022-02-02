using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    public Object del;

    private void OnTriggerExit(Collider des)
    {
        des.GetComponentInParent<Rigidbody>();
        Destroy(del);
    }
}