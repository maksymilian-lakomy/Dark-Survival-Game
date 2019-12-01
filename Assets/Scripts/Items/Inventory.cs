﻿﻿﻿using System;
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
    private List<InventorySlot> inventoryItems = new List<InventorySlot>();
    // If you would like to have access to this inventory from another place.
    public List<InventorySlot> InventoryItems => inventoryItems; 
    
    private IItem equippedItem;
    // Same as above.
    public IItem EquippedItem => equippedItem; 
    
    [SerializeField]
    private int space = 6;
    public int Space => space;

    public void UpdateInventorySize(int space) {
        this.space = space;
        inventoryItems.Capacity = this.space;
    }
    
    public bool AddItem(IInventoryItem item, int amount) {
        foreach (InventorySlot slot in inventoryItems) {
            if (slot.item == null) {
                slot.item = new InventoryKeyValuePair(item, amount);
            } 
        }
        return true;
    }

    public InventoryKeyValuePair GetItem(int slotNumber) {
        if (slotNumber > inventoryItems.Count)
            return null;
        return inventoryItems[slotNumber].item;
    }
    
    public bool RemoveItem(int slotNumber) {
        if (slotNumber > inventoryItems.Count)
            return false;
        inventoryItems[slotNumber].item = null;
        return true;
    }

    public IItem EquipItem(IItem item) {
        IItem previousEquippedItem = equippedItem;
        equippedItem = item;
        return previousEquippedItem;
    }
    
    public IItem UnequipItem() {
        if (equippedItem == null)
            return null;
        IItem item = equippedItem;
        equippedItem = null;
        return item;
    }


  }
