using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

public class Character : MonoBehaviour, ITemperatureBehavior, IHungerBehaviour {

    [SerializeField]
    protected float temperature;

    protected float hunger;

    private void Awake()
    {
        InvokeRepeating(nameof(HungerLogic), 0f, 1f);
    }

    public float Temperature {
        get => temperature;
    }

    public void TemperatureChange(float change) {
        temperature += change;
        Debug.Log("Character walked near to fireplace");
    }


    public float Hunger { get; }
    public void HungerChange(float change)
    {
        hunger = Mathf.Clamp(hunger + change, 0f, 100f);
    }

    private void HungerLogic() {
        HungerChange(-.5f);
        
    }
}
