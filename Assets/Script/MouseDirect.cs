using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDirect : MonoBehaviour
{
    public Object destroy;
    void OnMouseExit()
    {
        GetComponentInParent<Rigidbody>();
        Destroy(destroy);
    }
}
