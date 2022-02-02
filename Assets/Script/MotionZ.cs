using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionZ : MonoBehaviour
{
    public float speed;
    public float positLeft;
    public float positRight;
    void Start()
    {
        speed = Random.Range(0.5f, 3);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.z < positLeft)
        {
            speed = -speed;
        }
        if (transform.position.z > positRight)
        {
            speed = Random.Range(0.5f, 3);
        }
    }
}
