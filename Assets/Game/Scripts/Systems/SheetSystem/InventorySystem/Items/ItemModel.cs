using UnityEngine;

namespace Game.Systems.SheetSystem.InventorySystem
{
    public abstract class ItemModel<D> : MonoBehaviour where D : ItemData
    {
        public D data;
    }
}