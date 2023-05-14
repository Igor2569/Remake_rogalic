using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Systems.CameraSystem
{
	public class CameraFolow : MonoBehaviour
	{
		public Camera camera;
		[OnValueChanged("RefreshPosition")]
		public Transform folow;
		[Min(0)]
		public float smoothing = 0.1f;
		[OnValueChanged("RefreshPosition")]
		public Vector3 offset;

		private void FixedUpdate()
		{
			transform.position = Vector3.Lerp(transform.position, folow.position + offset, smoothing);
		}

		private void GoToFolow()
		{
			transform.position = folow?.position ?? transform.position;
		}

		private void RefreshPosition()
		{
			if (folow == null) return;
			transform.position = folow.position + offset;
		}
	}
}