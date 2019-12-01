using System;
using ItemInterfaces;

namespace DefaultNamespace.Items {
    [Serializable]
    public class InventoryKeyValuePair {
        public InventoryKeyValuePair(ItemInventoryData item, int amount) {
            Item = item;
            Amount = amount;
        }
        
        public ItemInventoryData Item;
        public int Amount;
    }
}