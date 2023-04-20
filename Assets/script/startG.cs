using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startG : MonoBehaviour
{
    public string LoadScn;

    public void LoadScene()
    {
        SceneManager.LoadScene(LoadScn);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
