using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animsound : MonoBehaviour
{
    AudioSource aS;

    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        aS.Play();

        
    }
}
