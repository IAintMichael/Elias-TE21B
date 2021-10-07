using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Randomization : MonoBehaviour
{
    bool canRandomize;
    PlayerMovement playerMovement;
    public float timer;

    public GameObject[] levelPrefabs;

    public Transform spawnerTransform;

    private void Start()
    {
        //F�renklar hela arbetet med att hitta "PlayerMovement" scriptet
        playerMovement = FindObjectOfType<PlayerMovement>();

        canRandomize = true;
    }

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

        int randomizer = Random.Range(0, levelPrefabs.Length);

        yield return new WaitForSeconds(timer/2);

        Spawn(randomizer);
    }


    void Spawn(int index)
    {
        Instantiate(levelPrefabs[index], spawnerTransform.position, spawnerTransform.rotation);
    }

}
