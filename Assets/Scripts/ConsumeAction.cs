using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[CreateAssetMenu (menuName = "Items/ConsumeAction")]
[Serializable]
public class ConsumeAction : ItemAction
{
    [SerializeField] private float hungerChange = 0f;
    public override void Action(IBehavior hungerBehavior) {
        IHungerBehavior behavior = hungerBehavior as IHungerBehavior;
        if (behavior == null)
            return;
        behavior.HungerChange(-10f);
    }
}