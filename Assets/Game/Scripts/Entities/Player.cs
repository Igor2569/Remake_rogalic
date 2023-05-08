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
        public Rigidbody2D rb;
        private float speed = 30f;
        private float movey;
        private Vector2 moveVector;

        void Update()
        {
            Go();
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
}