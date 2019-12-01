using System;
using System.Collections;
using System.Collections.Generic;
using ItemInterfaces;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ItemData")] 
public class ItemData : ScriptableObject, IItem {
    
    protected string itemName;
    protected string itemDescription;
    protected GameObject itemPrefab;
    
    public string ItemName => itemName;
    public string ItemDescription => itemDescription;
    public GameObject ItemPrefab => itemPrefab;

    public List<ItemAction> ItemActions;
}
