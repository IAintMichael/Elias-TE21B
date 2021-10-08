using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{


    StarChange starChange;

    GameObject player;



    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;

        starChange = player.GetComponent<StarChange>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int randomizer = Random.Range(0, 2);

            Debug.Log(randomizer);

            if(randomizer == 0)
            {
                StartCoroutine(starChange.SlowDown());
            } 
            else if(randomizer == 1)
            {
                StartCoroutine(starChange.StarPower());
            }

            

            Destroy(gameObject);
        }
    }
}
