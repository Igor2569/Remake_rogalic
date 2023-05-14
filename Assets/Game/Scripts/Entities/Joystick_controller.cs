using UnityEngine;

namespace Game.Entities
{
    public class Joystick_controller : MonoBehaviour
    {
        public Animator animator;
        public Rigidbody2D rigidBody;
        public FixedJoystick joystick;
        private int horizontalHash;
        private int verticalHash;
        public float joystick_speed = 250f;
        public Vector2 joystick_movement;
        void Start()
        {
            horizontalHash = Animator.StringToHash("Horizontal");
            verticalHash = Animator.StringToHash("Vertical");
        }

        // Update is called once per frame
        void Update()
        {
            joystick_movement = new Vector2(joystick.Horizontal, joystick.Vertical);//Input


            var joystick_scale = transform.localScale;
            joystick_scale.x = joystick_movement.x >= 0 ? 1f : -1f;
            transform.localScale = joystick_scale;

            animator.SetFloat(horizontalHash, joystick_movement.x);
            animator.SetFloat(verticalHash, joystick_movement.y);
        }
        private void FixedUpdate()
        {
            rigidBody.velocity = new Vector2(joystick.Horizontal * joystick_speed * Time.fixedDeltaTime, joystick.Vertical * joystick_speed * Time.fixedDeltaTime);
        }
    }
}

