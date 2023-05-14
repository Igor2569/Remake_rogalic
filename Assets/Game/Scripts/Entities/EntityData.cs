using Game.Systems.SheetSystem;

using Sirenix.OdinInspector;

using UnityEngine;

namespace Game.Entities
{
    [CreateAssetMenu(fileName = "EntityData", menuName = "Game/Entity")]
    public class EntityData : ScriptableObject
    {
		[HideLabel]
		public Information information;
		[Space]
		public Stats.Settings stats;
	}
}