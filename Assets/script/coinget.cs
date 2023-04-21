using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class coinget : MonoBehaviour
{
    public AudioSource sounds;
    public score points;
    public AudioClip sound;


    void start()
    {
        sounds = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            points.scores += 1 ;
            sounds.PlayOneShot(sound, 1);

            Destroy(gameObject, .5f);

        }
       
    }

}
