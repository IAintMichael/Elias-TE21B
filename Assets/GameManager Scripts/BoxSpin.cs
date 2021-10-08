using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpin : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 10, 0) * speed);
    }
}
