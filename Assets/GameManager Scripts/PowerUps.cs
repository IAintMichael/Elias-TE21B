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






}
