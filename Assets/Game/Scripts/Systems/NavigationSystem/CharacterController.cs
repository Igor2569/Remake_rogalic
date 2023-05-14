using Game.UI;

using StarSmithGames.Go;

using UnityEngine;

using Zenject;

namespace Game.Systems.NavigationSystem
{
    public class CharacterController : MonoBehaviour
    {
		public Rigidbody2D rigidBody;
		[Space]
		public float speed = 5f;

		[Inject]
		private ViewRegistrator viewRegistrator;

		private Vector2 movement;

		private HUDScreen screen;

		private void Start()
		{
			screen = viewRegistrator.GetAs<HUDScreen>();
		}

		private void Update()
		{
			movement = new Vector2(screen.joystick.Horizontal, screen.joystick.Vertical);//Input

#if UNITY_EDITOR
			if(movement == Vector2.zero)
			{
				movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));//Input
			}
#endif
		}

		private void FixedUpdate()
		{
			rigidBody.MovePosition(rigidBody.position + (movement * speed * Time.fixedDeltaTime));
		}

		public Vector2 GetMovement()
		{
			return movement;
		}
	}
}