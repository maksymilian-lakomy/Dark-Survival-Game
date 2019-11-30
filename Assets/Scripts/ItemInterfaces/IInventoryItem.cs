﻿using UnityEngine;
 namespace ItemInterfaces {
    public interface IInventoryItem : IItem
    {
        Sprite InventorySprite { get; }
    }
}