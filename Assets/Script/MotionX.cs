using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionX : MonoBehaviour
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
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (transform.position.x > positLeft)
        {
            speed = -speed;
        }
        if (transform.position.x < positRight)
        {
            speed = Random.Range(0.5f, 3);
        }
    }
}
