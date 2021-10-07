using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [Header("Speeds")]
    public float speed;
    public float rotationspeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Xfloat = Input.GetAxis("Horizontal");
        float Yfloat = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Xfloat, 0, Yfloat) * Time.deltaTime * speed;

        rb.AddForce(movement);
        Vector3 rotation = new Vector3(rotationspeed, 0, rotationspeed);
        transform.Rotate(rotation * rotationspeed);

    }
}
