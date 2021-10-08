 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlidingScript : MonoBehaviour
{
    public float slidingSpeed;
    bool toGoal;

    [Header("Vectors")]
    public Vector3 startVector;
    public Vector3 goalVector;

    // Update is called once per frame
    void Update()
    {
        if(transform.position == goalVector)
        {
            toGoal = false;
        } else if(transform.position == startVector)
        {
            toGoal = true;
        }



        if (toGoal)
        {
            transform.position = Vector3.MoveTowards(transform.position, goalVector, Time.deltaTime * slidingSpeed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startVector, Time.deltaTime * slidingSpeed);
        }
    }
}
