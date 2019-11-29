using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class WorldItem : MonoBehaviour
{
    [SerializeField]
    public float radius;
    
    public SpriteRenderer spriteRenderer;
    public Collider2D collider;
    public ItemData itemData;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        IBehavior behaviour = other.GetComponent<IBehavior>();
        foreach (ItemAction itemAction in itemData.itemActions) {
            itemAction.Action(behaviour);
        }
    }
}
