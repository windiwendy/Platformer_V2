using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchBull : MonoBehaviour
{

    public Animator aniamtion;
    //AudioSource aS;


    // Start is called before the first frame update
    void Start()
    {
        //aS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        aniamtion.SetBool("switch", true);
        //aS.Play();


    }
}
