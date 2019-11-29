﻿using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ConsumeAction")] 
public class ConsumeAction : ItemAction<IHungerBehavior>
{
    [SerializeField] private float hungerChange = 0f;
    public override void Action(IHungerBehavior hungerBehavior) {
        
    }
}