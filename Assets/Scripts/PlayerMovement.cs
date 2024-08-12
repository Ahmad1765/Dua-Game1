using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float xInput;
    float zInput;
    Rigidbody rb;

    public float speed = 10f;

    public float jumpForce = 5f;

    Camera cam;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.LookAt(transform.position);
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(xInput*speed,rb.velocity.y,zInput*speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jumpForce);
        }
    }
}
