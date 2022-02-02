using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemy;
    public float force;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, enemy.position, force * Time.deltaTime);
    }
}
