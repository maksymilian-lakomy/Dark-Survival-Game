using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

public class Character : MonoBehaviour, ITemperatureBehavior, IHungerBehaviour {

    [SerializeField]
    protected float temperature;

    [SerializeField]
    protected float hunger;

    private void Awake() {
        InvokeRepeating(nameof(HungerLogic), 0f, 1f);
        InvokeRepeating(nameof(ReactingToWeather), 0f, 1f);
    }

    public float Temperature => temperature;

    public void TemperatureChange(float change) {
        temperature += change;
    }

    private void ReactingToWeather() {
        temperature = Mathf.MoveTowards(temperature, WeatherController.i.CurrentTemperature, .25f);
    }

    public float Hunger => hunger;
    public void HungerChange(float change) {
        hunger = Mathf.Clamp(hunger + change, 0f, 100f);
    }

    private void HungerLogic() {
        HungerChange(-.5f);
    }
}
