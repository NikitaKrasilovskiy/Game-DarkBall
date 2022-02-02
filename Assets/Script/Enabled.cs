using UnityEngine;
using System.Collections;

public class Enabled : MonoBehaviour
{
    public MeshRenderer ShowZone;
    private void OnTriggerExit(Collider des)
    {
        des.GetComponentInParent<Rigidbody>();
        ShowZone.enabled = true;
    }
}