using Sirenix.OdinInspector;

using StarSmithGames.Core;

namespace Game.Systems.SheetSystem
{
	public abstract class Stat : Attribute
	{
		public override string LocalizationKey => $"{base.LocalizationKey}stats.";

		protected Stat(float currentValue) : base(currentValue) { }
	}

	public abstract class StatBar : AttributeBar
	{
		public override string LocalizationKey => $"{base.LocalizationKey}stats.";

		public StatBar(float value, float min, float max) : base(value, min, max) { }

		public StatBar(Bar bar) : base(bar.value, bar.min, bar.max) { }

		public Bar GetBar()
		{
			return new Bar() { value = CurrentValue, min = MinValue, max = MaxValue };
		}
	}

	#region Stat
	public class SpeedStat : Stat
	{
		public SpeedStat(float currentValue) : base(currentValue) { }
	}
	#endregion

	#region StatBar
	public class HitPointsStat : StatBar
	{
		public HitPointsStat(float currentValue, float minValue, float maxValue) : base(currentValue, minValue, maxValue) { }

		public HitPointsStat(Bar bar) : base(bar.value, bar.min, bar.max) { }
	}

	public class FatiguePoints : StatBar
	{
		public FatiguePoints(float currentValue, float minValue, float maxValue) : base(currentValue, minValue, maxValue) { }

		public FatiguePoints(Bar bar) : base(bar.value, bar.min, bar.max) { }
	}
	#endregion

	[InlineProperty]
	[System.Serializable]
	public struct Bar
	{
		[BoxGroup]
		[MinValue("min"), MaxValue("max")]
		public float value;
		public float min;
		public float max;
	}
}