using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D player1;
    public float speed;
    public float input;
    public float jumpforce;

    public LayerMask groundLayer;
    public Transform feetPosition;
    public float groundcheckC;
    private bool inGround;
    public SpriteRenderer spriteRenderer;
   


     void Start()
    {
       // Animator pl = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update()
    {
        Animator pl = GetComponent<Animator>();


        input = Input.GetAxis("Horizontal");
        if(input  < 0 )
        {
            spriteRenderer.flipX = false;

        }
        else
        {
            spriteRenderer.flipX = true;
        }



        inGround = Physics2D.OverlapCircle(feetPosition.position, groundcheckC,groundLayer);

        if(inGround == true && Input.GetButton("Jump"))
        {
            player1.velocity = Vector2.up * jumpforce;

        }
        pl.SetFloat("speed", input);

    }
    void FixedUpdate()
    {
        
        
        player1.velocity = new Vector2 (input * speed, player1.velocity.y);


    }
}
