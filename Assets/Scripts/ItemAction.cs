using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

[Serializable]
public abstract class ItemAction: ScriptableObject
{
    //It should be made with beautiful generic class but unity has cancer or something.
    public abstract void Action(IBehavior behavior);
}
