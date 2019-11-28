using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldItem : MonoBehaviour
{
    [SerializeField]
    public float radius;
    
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody2D;
    public ItemData itemData;

    public List<ItemAction> itemActions;          
    
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

}
