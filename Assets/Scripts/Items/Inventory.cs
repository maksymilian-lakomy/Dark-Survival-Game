﻿﻿using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using ItemInterfaces;
using UnityEngine;

public class Inventory : MonoBehaviour {
    
    #region Singleton

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;

    }

    #endregion

    public List<IInventoryItem> inventoryItems = new List<IInventoryItem>();
    public IItem equippedItem; // interfejs, bo mozna w łapce trzymac na przyklad kurczaka, ktory jest
                               // MonoBehaviour a nie InventoryItemData (to samo z ekwipunkiem)
    public int Space;

    public bool AddItem(IInventoryItem item) {
        if (inventoryItems.Count >= Space) {
            Debug.Log("Not enough room.");
            return false;
        }
        inventoryItems.Add(item);
        return true;
    }

    public bool AddItem(IItem item) {
        if (equippedItem == null) {
            // equippedItem = ten item na którym jest focus
            return true;
        } else {
            return false;
        }
    }

    public void DropEquippedItem() {
        if (equippedItem != null)
        {
            ItemData itemData = equippedItem as ItemData;
            if (itemData != null)
            {
                WorldItem.CreateWorldItem(itemData);
            }
            equippedItem = null;
        }
    }
}
