using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public bool is_Star;



    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (!is_Star)
        {
            if (other.gameObject.tag == "Enemy")
            {
                Destroy(gameObject);
            }
        }
        else
        {
            if (other.gameObject.tag == "Enemy")
            {
                Destroy(other.gameObject);
            }
        }
        
       
    }
}
