using UnityEngine;
using System.Collections;

public class RigidbidyOn : MonoBehaviour
{
    public Rigidbody rb;
    private void OnTriggerExit(Collider des)
    {
        des.GetComponentInParent<Rigidbody>();
        rb.GetComponent<Rigidbody>().useGravity = true;
    }
}