using System;
using ItemInterfaces;

namespace DefaultNamespace.Items {
    [Serializable]
    public class InventoryKeyValuePair {
        public InventoryKeyValuePair(CollectibleItemData item, int amount) {
            Item = item;
            Amount = amount;
        }
        
        public CollectibleItemData Item;
        public int Amount;
    }
}