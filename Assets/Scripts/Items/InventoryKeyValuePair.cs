using System;
using ItemInterfaces;

namespace DefaultNamespace.Items {
    [Serializable]
    public class InventoryKeyValuePair {
        public InventoryKeyValuePair(IItem item, int amount) {
            Item = item;
            Amount = amount;
        }
        
        public IItem Item;
        public int Amount;
    }
}