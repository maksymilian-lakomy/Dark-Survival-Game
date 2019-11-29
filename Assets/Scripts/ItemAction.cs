﻿using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

public abstract class ItemAction<T> : ScriptableObject where T : IBehavior
{
    public abstract void Action(T behavior);
}
