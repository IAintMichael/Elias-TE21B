using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xfloat = Input.GetAxis("Horizontal");
        float Yfloat = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Xfloat, 0, Yfloat) * Time.deltaTime * speed;

        rb.AddForce(movement);

    }
}
