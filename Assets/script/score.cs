using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public int scores;
    public TMP_Text scoretxt;
    public string LoadScn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "Score:  " + scores;

        if(scores == 10)
        {
            SceneManager.LoadScene(LoadScn);
        }
    }
}
