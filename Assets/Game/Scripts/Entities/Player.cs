using UnityEngine;

namespace Game.Entities
{
	public class Player : MonoBehaviour
    {
        public Animator animator;
        public Rigidbody2D rigidBody;
		public float speed = 5f;
		private Vector2 movement;
		public FixedJoystick joystick;
        private int horizontalHash;
        private int verticalHash;
		
		private void Start()
		{
			horizontalHash = Animator.StringToHash("Horizontal");
			verticalHash = Animator.StringToHash("Vertical");
		}

		private void Update()
		{
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));//Input
			
			var scale = transform.localScale;
			scale.x = movement.x >= 0 ? 1f : -1f;

            
            transform.localScale = scale;
            animator.SetFloat(horizontalHash, movement.x);
			animator.SetFloat(verticalHash, movement.y);
		}

		private void FixedUpdate()
        {
			rigidBody.MovePosition(rigidBody.position + (movement * speed * Time.fixedDeltaTime));
		}
	}
}