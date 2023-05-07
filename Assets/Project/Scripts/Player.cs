using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    private float movex;
    public Animator anim;
    private float speed = 30f;
    private Rigidbody2D rb;
    private float movey;
    private Vector2 moveVector;
    private Action movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = Go;
    }

    // Update is called once per frame
    void Update()
    {
        movement.Invoke();
    }
    private void Go()
    {
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");
        moveVector.x = Input.GetAxis("Horizontal") * Time.deltaTime;
        moveVector.y = Input.GetAxis("Vertical") * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector * speed);
        if (movex == 0 && movey == 0)
        {
            anim.SetBool("IsRunning", false);
        }
        else
        {
            anim.SetBool("IsRunning", true);
        }
    }
}
