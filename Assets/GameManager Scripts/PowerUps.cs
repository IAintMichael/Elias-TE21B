using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] float gravityFactor;
    public float changablePlayerSpeed;

    DestroyObject destroyGame;

    GameObject player;



    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;

        destroyGame = player.GetComponent<DestroyObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int randomizer = Random.Range(0, 2);

            Debug.Log(randomizer);

            if(randomizer == 0)
            {
                StartCoroutine(SlowMotion());
            } 
            else if(randomizer == 1)
            {
                StartCoroutine(StarPower());
            }

            

            Destroy(gameObject);
        }
    }

    //Alla IEnumerators
    IEnumerator SlowMotion()
    {
        Time.timeScale = gravityFactor * Time.fixedDeltaTime;
        player.GetComponent<PlayerMovement>().speed *= changablePlayerSpeed;

        yield return new WaitForSeconds(5f);

        player.GetComponent<PlayerMovement>().speed /= changablePlayerSpeed;
        Time.timeScale = 1;
    }

    IEnumerator StarPower()
    {
        destroyGame.is_Star = true;

        yield return new WaitForSeconds(8f);

        destroyGame.is_Star = false;
    }
}
