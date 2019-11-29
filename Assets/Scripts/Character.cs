using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

public class Character : MonoBehaviour, ITemperatureBehavior, IHungerBehavior {

    protected float temperature;

    [SerializeField] protected float hunger;
    

    private void Awake() {
        InvokeRepeating(nameof(HungerLogic), 0f, 1f);
    }

    public float Temperature {
        get => temperature;
    }

    public void TemperatureChange(float change) {
        temperature += change;
    }


    public float Hunger {
        get => hunger;
    }
    
    public void HungerChange(float change) {
        hunger = Mathf.Clamp(hunger + change, 0f, 100f);
    }

    private void HungerLogic() {
        HungerChange(-.5f);
        if (hunger == 0) {
            // Debug.Log("y o u  d i e d");
        }
    }
}
