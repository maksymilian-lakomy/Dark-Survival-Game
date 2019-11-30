﻿﻿using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
  using DefaultNamespace.Items;
  using ItemInterfaces;
using UnityEngine;

  
  [Serializable]
  // Inventory is no longer singleton. Everything that you want can now have its own container of objects.
public class Inventory  {
    
      [SerializeField]
    private List<InventoryKeyValuePair> inventoryItems = new List<InventoryKeyValuePair>();
    // If you would like to have access to this inventory from another place.
    public List<InventoryKeyValuePair> InventoryItems => inventoryItems; 
    
    private IItem equippedItem;
    // Same as above.
    public IItem EquippedItem => equippedItem; 
    
    [SerializeField]
    private int space = 6;
    public int Space => space;
    
    public bool AddItem(IInventoryItem item, int amount) {
        if (inventoryItems.Count > Space) {
            return false;
        }
        inventoryItems.Add(new InventoryKeyValuePair(item, amount));
        return true;
    }

    public IItem EquipItem(IItem item) {
        IItem previousEquippedItem = equippedItem;
        equippedItem = item;
        return previousEquippedItem;
    }

    public void DropItem(IItem item) {
        ItemData itemData = item as ItemData;
        if (itemData)
            WorldItem.CreateWorldItem(itemData);
    }

    public void UnequipItem() {
        if (equippedItem == null)
            return;
        IInventoryItem inventoryItem = equippedItem as IInventoryItem;
    }
  }
