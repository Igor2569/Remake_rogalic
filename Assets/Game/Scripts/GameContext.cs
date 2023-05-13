using Game.Managers.StorageManager;

using StarSmithGames.Go.ApplicationHandler;

using Zenject;

namespace Game
{
	public class GameContext : MonoInstaller
	{
		public override void InstallBindings()
		{
			SignalBusInstaller.Install(Container);
			ApplicationHandlerInstaller.Install(Container);

			Container.BindInterfacesAndSelfTo<StorageManager>().AsSingle().NonLazy();
		}
	}
}