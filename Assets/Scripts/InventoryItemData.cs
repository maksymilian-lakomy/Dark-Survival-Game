using UnityEngine;
using ItemInterfaces;
public class InventoryItemData : ItemData, IInventoryItem
{
    protected Sprite inventorySprite;
    public Sprite InventorySprite => inventorySprite;
}
