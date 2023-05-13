using StarSmithGames.Core.StorageSystem;

namespace Game.Managers.StorageManager
{
	public class StorageManager
	{
		public ISaveLoad<Storage> saveLoad;

		public StorageManager()
		{
			saveLoad = new PlayerPrefsSaveLoad<Storage>("data");
			saveLoad.Save();
		}
	}

	public class Storage : StarSmithGames.Core.StorageSystem.Storage
	{
		public StorageData<int> DeathCount { get; private set; }

		//settings
		public StorageData<bool> IsSound { get; private set; }
		public StorageData<bool> IsMusic { get; private set; }
		public StorageData<bool> IsVibration { get; private set; }

		protected override void Initialization()
		{
			base.Initialization();

			DeathCount = new(Database, "death_count", 0);

			IsSound = new(Database, "is_sound", true);
			IsMusic = new(Database, "is_music", true);
			IsVibration = new(Database, "is_vibration", true);
		}

		protected override void Purge() { }
	}
}