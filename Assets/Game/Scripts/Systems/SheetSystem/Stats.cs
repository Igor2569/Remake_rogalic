using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Systems.SheetSystem
{
    public class Stats
    {
		public HitPointsStat HitPoints { get; }
		public FatiguePoints FatiguePoints { get; }

		public SpeedStat Speed { get; }

		public Stats(Settings settings)
		{
			HitPoints = new(settings.hp);
			FatiguePoints = new(settings.fp);
			Speed = new(settings.speed);
		}

		//No Loading data
		//public Stats(Data data)
		//{
		//	HitPoints = new(data.hp);
		//	FatiguePoints = new(data.fp);
		//	Speed = new(data.speed);
		//}

		//public Data GetData()
		//{
		//	return new Data()
		//	{
		//		hp = HitPoints.GetBar(),
		//		fp = FatiguePoints.GetBar(),
		//		speed = Speed.CurrentValue,
		//	};
		//}

		//[System.Serializable]
		//public class Data
		//{
		//	public Bar hp;
		//	public Bar fp;
		//	public float speed;
		//}

		[System.Serializable]
		public class Settings
		{
			public Bar hp = new Bar() { value = 5, min = 0, max = 5};
			public Bar fp = new Bar() { value = 100, min = 0, max = 100 };
			[Min(1)]
			public float speed = 1;

			[Button(DirtyOnClick = true)]
			private void Reset()
			{
				hp = new Bar() { value = 5, min = 0, max = 5 };
				fp = new Bar() { value = 100, min = 0, max = 100 };
				speed = 1;
			}
		}
	}
}