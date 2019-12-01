using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class WorldItem : MonoBehaviour
{
    [SerializeField]
    public float radius = 10f;
    
    private SpriteRenderer spriteRenderer;
    private CircleCollider2D rangeCollider2D;
    
    public ItemData ItemData;

    public int Amount = 0;

    private void Awake() {
        if (!spriteRenderer)
            spriteRenderer = GetComponent<SpriteRenderer>();
        if (!rangeCollider2D)
            rangeCollider2D = GetComponent<CircleCollider2D>();
        rangeCollider2D.isTrigger = true;
        rangeCollider2D.radius = radius;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        IBehavior behaviour = other.GetComponent<IBehavior>();
        foreach (ItemAction itemAction in ItemData.ItemActions) {
            itemAction.Action(behaviour);
        }
    }

    public static GameObject CreateWorldItem(ItemData itemData, int amount) {
        GameObject newWorldItem = new GameObject(itemData.ItemName);
        newWorldItem.AddComponent<BoxCollider2D>();
        newWorldItem.AddComponent<CircleCollider2D>();
        newWorldItem.AddComponent<SpriteRenderer>();
        newWorldItem.AddComponent<WorldItem>();
        newWorldItem.GetComponent<WorldItem>().ItemData = itemData;
        newWorldItem.GetComponent<WorldItem>().Amount = amount;
        return newWorldItem;
    }
}
