using StarSmithGames.Go;

using Zenject;

namespace Game.UI
{
    public class HUDScreen : ViewBase
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