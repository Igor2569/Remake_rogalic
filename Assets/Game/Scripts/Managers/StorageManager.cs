using StarSmithGames.Core;
using StarSmithGames.Core.StorageSystem;

namespace Game.Managers.StorageManager
{
	public class StorageManager : LazySingletonMonoDontDestroyOnLoad<StorageManager> { }

	public class Storage : StarSmithGames.Core.StorageSystem.Storage
	{
		public StorageData<int> DeathCount { get; private set; }

		protected override void Initialization()
		{
			base.Initialization();

			DeathCount = new(Database, "death_count", 0);
		}

		protected override void Purge() { }
	}
}