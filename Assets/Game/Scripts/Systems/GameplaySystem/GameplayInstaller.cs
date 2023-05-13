using UnityEngine;

using Zenject;

namespace Game.Systems.GameplaySystem
{
	[CreateAssetMenu(fileName = "GameplayInstaller", menuName = "Installers/GameplayInstaller")]
	public class GameplayInstaller : ScriptableObjectInstaller
	{
		public GameplayConfig gameplayConfig;

		public override void InstallBindings()
		{
			Container.BindInstance(gameplayConfig).AsSingle();
		}
	}
}