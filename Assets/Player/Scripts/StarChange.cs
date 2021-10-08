using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarChange : MonoBehaviour
{

    public Material[] allMats;

    DestroyObject destroyGame;

    public float gravityFactor;
    public float changablePlayerSpeed;

    private void Start()
    {
        destroyGame = GetComponent<DestroyObject>();
    }

    private void Update()
    {
        if (gameObject.GetComponent<DestroyObject>().is_Star)
        {
            gameObject.GetComponent<Renderer>().material = allMats[1];
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = allMats[0];
        }
    }
    public IEnumerator StarPower()
    {
        destroyGame.is_Star = true;

        yield return new WaitForSeconds(1f);

        destroyGame.is_Star = false;
    }
    public IEnumerator SlowDown()
    {
        Time.timeScale = gravityFactor * Time.fixedDeltaTime;
        GetComponent<PlayerMovement>().speed *= changablePlayerSpeed;

        yield return new WaitForSeconds(1f);

        GetComponent<PlayerMovement>().speed /= changablePlayerSpeed;
        Time.timeScale = 1;
    }
}
