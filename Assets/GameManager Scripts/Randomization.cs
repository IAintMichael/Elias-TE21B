using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
    bool canRandomize;


    private void Update()
    {
        if (canRandomize)
        {
            StartCoroutine(Randomize());
        }
    }

    IEnumerator Randomize() {
        canRandomize = false;

        yield return new WaitForSeconds(1f);
    }
}
