using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

public class Inventory : MonoBehaviour
{
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

    public List<ItemData> items = new List<ItemData>();
    public int Space;

    public bool AddItem(ItemData item)
    {
        if (items.Count >= Space)
        {
            Debug.Log("Not enough room.");
            return false;
        }
        items.Add(item);
        return true;
    }
}
