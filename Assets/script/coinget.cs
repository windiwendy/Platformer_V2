using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coinget : MonoBehaviour
{
    public score points;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            points.scores += 1 ;
            Destroy(gameObject);

        }
    }

}
