using StarSmithGames.Go;

using System;

using UnityEngine;

using Zenject;

namespace Game.UI
{
    public class HUDScreen : WindowBase
    {
        public FixedJoystick joystick;

        [Inject]
        private ViewRegistrator viewRegistrator;

		private void Awake()
		{
			viewRegistrator.Registrate(this);
		}

		private void OnDestroy()
		{
			viewRegistrator.UnRegistrate(this);
		}
	}
}