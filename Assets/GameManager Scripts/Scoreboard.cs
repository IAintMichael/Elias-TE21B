using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    float scoretimer;

    // Start is called before the first frame update
    void Start()
    {
        scoretimer = 0;
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoretimer += Time.deltaTime;
        Debug.Log(scoretimer);
    }
}
