using System;
using JetBrains.Annotations;

namespace DefaultNamespace.Items {
    [Serializable]
    public class InventorySlot {
        [CanBeNull] public InventoryKeyValuePair item = null;
    }
}