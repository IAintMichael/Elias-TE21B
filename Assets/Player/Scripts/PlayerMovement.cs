using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    [Header("Speeds")]
    public float speed;
    [SerializeField] float forwardSpeed;


    bool isGrounded;
    public LayerMask ground;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Xfloat = Input.GetAxis("Horizontal");

        isGrounded = Physics.Raycast(transform.position, -Vector3.up, 1.2f, ground);

        if (isGrounded)
        {
            Vector3 movement = new Vector3(Xfloat, 0, forwardSpeed) * Time.deltaTime * speed;
            rb.AddForce(movement);
        }
        else
        {
            Vector3 movement = new Vector3(Xfloat, 0, 0) * Time.deltaTime * speed;
            rb.AddForce(movement);
        }

        

        


    }
}
