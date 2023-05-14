using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Game.Entities
{
    public class Player : MonoBehaviour
    {
        private float movex;
        public Animator anim;
        public float speed = 30f;
        public Rigidbody2D rb;
        private float movey;
        private Vector2 moveVector;
        private Action movement;
        private float scalex;
        private float scaley = 4.039235f;
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
            if (movex==0f && movey == 0)
            {
                scalex = 3.574679f;
                transform.localScale = new Vector2(scalex, scaley);
                anim.SetFloat("Horizontal", 0f);
                anim.SetFloat("Vertical", 0f);
            }
            if (Input.GetKey(KeyCode.W))
            {
                scalex = 3.574679f;
                transform.localScale = new Vector2(scalex, scaley);
                anim.SetFloat("Horizontal", 0f);
                anim.SetFloat("Vertical", 1f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                scalex = 3.574679f;
                transform.localScale = new Vector2(scalex, scaley);
                anim.SetFloat("Horizontal", 0f);
                anim.SetFloat("Vertical", -1f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                scalex = 3.574679f;
                transform.localScale = new Vector2(scalex, scaley);
                anim.SetFloat("Horizontal", 1f);
                anim.SetFloat("Vertical", 0f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                scalex = -3.574679f;
                transform.localScale = new Vector2(scalex, scaley);
                anim.SetFloat("Horizontal", -1f);
                anim.SetFloat("Vertical", 0f);
            }
        }
    }
}