using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[Serializable]
public class ItemActionSerializer
{
    public ItemAction<IBehavior> ItemAction;
}

[CreateAssetMenu (menuName = "Items/ItemData")] 
public class ItemData : ScriptableObject {
    [SerializeField]
    public string itemName;
    [SerializeField]
    public Sprite icon = null;
    [SerializeField] 
    public string description;

    [SerializeField]
    public List<ItemActionSerializer> itemActions;
}
