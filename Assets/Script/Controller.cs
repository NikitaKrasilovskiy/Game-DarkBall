using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float JumpForce;
    public bool IsGround;
    public Transform cam;
    public AudioSource JumpingAudio;

        public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast (ray, out rh, 0.6f))
        {
            IsGround = true;
        }
        else
        {
            IsGround = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGround)
        {
            rb.AddForce(Vector3.up * JumpForce);
            JumpingAudio.Play();
        }
    }
    void FixedUpdate()
    {       
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(cam.transform.forward * force * Time.fixedDeltaTime);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(cam.transform.forward * -force * Time.fixedDeltaTime);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(cam.transform.right * force * Time.fixedDeltaTime);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(cam.transform.right * -force * Time.fixedDeltaTime);
    }
    private void Update()
    {
        Jump();
    }
}
