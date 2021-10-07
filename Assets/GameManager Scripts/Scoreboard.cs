using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoreboard : MonoBehaviour
{
    float scoretimer;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        scoretimer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score.SetText(scoretimer.ToString("F1") + "s");

        scoretimer += Time.deltaTime;
        Debug.Log(scoretimer);
    }
}
