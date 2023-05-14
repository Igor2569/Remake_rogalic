using Game.Systems.NavigationSystem;

using UnityEngine;

using CharacterController = Game.Systems.NavigationSystem.CharacterController;

namespace Game.Entities
{
	public class Player : MonoBehaviour
    {
		public Vector2 Movement => characterController.GetMovement();

		public CharacterController characterController;
		public AnimatorController animatorController;
	}
}