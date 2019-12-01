using ItemInterfaces;
using UnityEngine;

namespace DefaultNamespace {
    public class WorldInventoryItem: MonoBehaviour, IItem<ItemInventoryData> {
        protected ItemInventoryData itemData;
        public ItemInventoryData ItemData => itemData;
    }
}