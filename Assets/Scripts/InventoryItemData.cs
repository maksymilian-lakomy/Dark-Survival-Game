using UnityEngine;
public class InventoryItemData : ItemData
{
    protected int maxInStack;
    protected Sprite inventorySprite;
    
    public Sprite InventorySprite => inventorySprite;
    public int MaxInStack => maxInStack;
}
