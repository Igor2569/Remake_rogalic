using StarSmithGames.Go;

using Zenject;

namespace Game
{
	public class GameSceneContext : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<ViewRegistrator>().AsSingle();
		}
	}
}