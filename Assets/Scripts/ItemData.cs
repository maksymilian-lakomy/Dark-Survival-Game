using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ItemData")] 
public class ItemData : ScriptableObject {
    [SerializeField]
    public string name;
    [SerializeField]
    public Sprite icon = null;
    [SerializeField] 
    public string description;
}
