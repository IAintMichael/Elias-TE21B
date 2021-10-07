using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoreboard : MonoBehaviour
{
    float scoretimer;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        scoretimer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score.text = scoretimer.ToString("F1") + "s";

        scoretimer += Time.deltaTime;
        Debug.Log(scoretimer);
    }
}
