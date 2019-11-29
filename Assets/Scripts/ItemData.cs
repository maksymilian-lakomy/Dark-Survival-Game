using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ItemData")] 
public class ItemData : ScriptableObject {
    [SerializeField]
    public string name;
    [SerializeField]
    public Sprite icon = null;
    [SerializeField] 
    public string description;

    public List<ItemAction<IBehavior>> itemActions;
}
