using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using DefaultNamespace;
using ItemInterfaces;
using UnityEditor;
using UnityEngine;

public class WorldCollectibleItem : MonoBehaviour, IItem<CollectibleItemData> {
    [SerializeField]
    protected new CollectibleItemData itemData;

    public new CollectibleItemData Data => itemData;
}
 