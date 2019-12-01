using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using ItemInterfaces;
using UnityEngine;

public class WorldItem : MonoBehaviour, IItem<ItemData> {
    protected ItemData itemData;
    public ItemData ItemData => itemData;
}
