using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ItemData")] 
public class ItemData : ScriptableObject {
    [SerializeField]
    public string ItemName;
    [SerializeField]
    public Sprite Icon = null;
    [SerializeField] 
    public string Description;

    [SerializeField]
    public List<ItemAction> ItemActions;
}
