using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
    bool canRandomize;


    private void Update()
    { 
        //S� att randomizern inte g�r av f�r ofta
        if (canRandomize)
        {
            //Starta Randomizern
            StartCoroutine(Randomize());
        }
    }

    //Sj�lvaste Randomizern
    IEnumerator Randomize() {
        canRandomize = false;

        yield return new WaitForSeconds(1f);
    }
}
