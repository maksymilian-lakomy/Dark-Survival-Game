using System;
using System.Collections;
using System.Collections.Generic;
using ItemInterfaces;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ItemData")] 
public class ItemData : ScriptableObject{
    
    public string ItemName;
    public string ItemDescription;
    public GameObject ItemPrefab;

    public List<ItemAction> ItemActions;
}
