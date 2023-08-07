using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movSp = 3f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movem;
    
    public Vector2 respawnPoint;

    void Start(){
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   

        
        movem.x = Input.GetAxisRaw("Horizontal");
        movem.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movem.x);
        animator.SetFloat("Vertical", movem.y);
        animator.SetFloat("Speed", movem.sqrMagnitude);
    }

    void FixedUpdate(){
        
        rb.MovePosition(rb.position + movem * movSp * Time.fixedDeltaTime);
 
    }


    void Respawn(){
        transform.position = respawnPoint;
    }
}
