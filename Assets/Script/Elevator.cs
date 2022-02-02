using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform elevatorTop;
    public float forceUp;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            elevatorTop.transform.position += elevatorTop.transform.up * forceUp * Time.deltaTime;
        }
    }
}