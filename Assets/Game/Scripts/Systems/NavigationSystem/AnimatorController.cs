using Game.Entities;

using UnityEngine;

namespace Game.Systems.NavigationSystem
{
    public class AnimatorController : MonoBehaviour
    {
		public Player player;
		[Space]
		public Animator animator;

		private int horizontalHash;
		private int verticalHash;

		private void Start()
		{
			horizontalHash = Animator.StringToHash("Horizontal");
			verticalHash = Animator.StringToHash("Vertical");
		}

		private void Update()
		{
			//Rotation
			var scale = transform.localScale;
			scale.x = player.Movement.x >= 0 ? 1f : -1f;
			transform.localScale = scale;

			//Animation
			animator.SetFloat(horizontalHash, player.Movement.x);
			animator.SetFloat(verticalHash, player.Movement.y);
		}
	}
}