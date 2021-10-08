using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] float gravityFactor;

    public void SlowMotion()
    {
        Time.timeScale = gravityFactor * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            SlowMotion();

            Destroy(gameObject);
        }
    }




}
