using System;
using ItemInterfaces;

namespace DefaultNamespace.Items {
    [Serializable]
    public class InventoryKeyValuePair {
        public InventoryKeyValuePair(ItemData item, int amount) {
            Item = item;
            Amount = amount;
        }
        
        public ItemData Item;
        public int Amount;
    }
}