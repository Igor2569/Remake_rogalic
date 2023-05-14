using Sirenix.OdinInspector;

using UnityEngine;

namespace Game.Systems.SheetSystem.InventorySystem
{
    public abstract class ItemData : ScriptableObject
    {
		[HideLabel]
		public Information information;
		[Space]
		public ItemRarity rarity = ItemRarity.Common;
	}

	public enum ItemRarity
	{
		Common,
		Rare,
		Epic,
		Legendary,
		Set,
	}
}