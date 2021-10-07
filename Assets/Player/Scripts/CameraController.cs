using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraPosition;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        cameraPosition.position = transform.position + offset;
    }
}
