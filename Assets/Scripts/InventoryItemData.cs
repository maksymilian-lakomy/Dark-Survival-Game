using UnityEngine;
using ItemInterfaces;
public class InventoryItemData : ItemData, IInventoryItem
{
    protected int maxInStack;
    protected Sprite inventorySprite;
    
    public Sprite InventorySprite => inventorySprite;
    public int MaxInStack => maxInStack;
}
