using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
    bool canRandomize;


    private void Update()
    { 
        //Så att randomizern inte går av för ofta
        if (canRandomize)
        {
            //Starta Randomizern
            StartCoroutine(Randomize());
        }
    }

    //Självaste Randomizern
    IEnumerator Randomize() {
        canRandomize = false;

        int randomizer = Random.Range(0, 4);



        yield return new WaitForSeconds(1f);
    }
}
