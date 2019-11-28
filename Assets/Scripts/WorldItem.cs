using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldItem : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    
    [SerializeField]
    public float radius;

    public virtual void Interact() {
        // cos tam cos tam elo
    }
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
}
