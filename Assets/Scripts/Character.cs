using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

public class Character : MonoBehaviour, ITemperatureBehavior {

    [SerializeField]
    protected float temperature;

    public float Temperature {
        get => temperature;
    }

    public void TemperatureChange(float change) {
        temperature += change;
        Debug.Log("Character walked near to fireplace");
    }

    
}
