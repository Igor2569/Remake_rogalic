using StarSmithGames.Core;
using StarSmithGames.Core.StorageSystem;

namespace Game.Managers.StorageManager
{
	public class StorageManager : LazySingletonMonoDontDestroyOnLoad<StorageManager> { }

	public class Storage : StarSmithGames.Core.StorageSystem.Storage
	{
		public IStorageData<int> DeathCount { get; private set; }

		protected override void Initialization()
		{
			base.Initialization();

			DeathCount = new StorageData<int>(Database, "death_count", 0);
		}

		protected override void Purge() { }
	}
}