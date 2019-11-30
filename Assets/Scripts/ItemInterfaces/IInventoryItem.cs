﻿using UnityEngine;
 namespace ItemInterfaces {
    public interface IInventoryItem : IItem
    {
        int MaxInStack { get; }
        Sprite InventorySprite { get; }
    }
}