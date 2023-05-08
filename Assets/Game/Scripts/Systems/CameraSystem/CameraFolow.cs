using Sirenix.OdinInspector;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Systems.CameraSystem
{
	public class CameraFolow : MonoBehaviour
	{
		public Camera camera;
		[OnValueChanged("GoToFolow", includeChildren: true)]
		public Transform folow;
		[Min(0)]
		public float smoothing = 0.1f;
		public Vector3 offset;

		private void FixedUpdate()
		{
			transform.position = Vector3.Lerp(transform.position, folow.position + offset, smoothing);
		}

		private void GoToFolow()
		{
			transform.position = folow?.position ?? transform.position;
		}
	}
}