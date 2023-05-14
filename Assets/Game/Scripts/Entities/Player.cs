using Game.Systems.NavigationSystem;
using Game.Systems.SheetSystem;

using UnityEngine;

using CharacterController = Game.Systems.NavigationSystem.CharacterController;

namespace Game.Entities
{
	public class Player : MonoBehaviour
    {
		public Vector2 Movement => characterController.GetMovement();

		public CharacterController characterController;
		public AnimatorController animatorController;

		public EntityData data;
		public Stats stats;

		private void Awake()
		{
			stats = new Stats(data.stats);
		}
	}
}