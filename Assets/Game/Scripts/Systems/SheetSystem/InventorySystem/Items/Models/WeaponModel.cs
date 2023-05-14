using UnityEngine;

namespace Game.Systems.SheetSystem.InventorySystem
{
	public class WeaponModel : ItemModel<WeaponItemData>
	{
		[Min(0)]
		public float cooldownReload = 1f;
		[Min(0)]
		public float cooldownFire = 0.1f;
		[Space]
		public Bar cartridgeClip = new Bar() { value = 10, min = 0, max = 10 };
	}
}