using Sirenix.OdinInspector;

using UnityEngine;

namespace Game.Systems.SheetSystem.InventorySystem
{
	[CreateAssetMenu(fileName = "ItemData", menuName = "Game/Sheet/Weapon")]
	public class WeaponItemData : EquippableItemData
	{
		[TitleGroup("Weapon")]
		[Range(0f, 50f)]
		public float range = 0.5f;
	}
}