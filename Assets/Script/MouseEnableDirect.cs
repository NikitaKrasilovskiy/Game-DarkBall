using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseEnableDirect : MonoBehaviour
{
    public TextMeshPro ShowZone;
    public Object destroy;
    public BoxCollider Box;
    void OnMouseExit()
    {
        GetComponentInParent<Rigidbody>();
        Destroy(destroy);
        ShowZone.enabled = true;
        Box.enabled = true;
    }
}
