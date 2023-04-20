using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int phealth;
    public int MaxHealth = 5;
    public health healthBar;


    public Vector3 starpos;
    public string LoadScn;



    // Start is called before the first frame update
    void Start()
    {
        phealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        
    }
    void Awake()
    {
        starpos = transform.position;
    }
    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        phealth-= amount;
        transform.position=starpos;

        healthBar.SetHealth(phealth);

        if (phealth <=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(LoadScn);
        }
    }
}
