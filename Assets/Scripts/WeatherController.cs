using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BehaviorInterfaces;
using UnityEngine;

public class WeatherController : MonoBehaviour {
    private List<ITemperatureBehavior> reactingToTemperature = new List<ITemperatureBehavior>();
    private float currentTemperature = -10f;

    public float CurrentTemperature => currentTemperature;


    public static WeatherController i;

    private void Awake() {
        FindAllObjectsReactingToTemperature();
        if (i == null)
            i = this;
        else if (i != this)
            Destroy(gameObject);
    }
    
    private void FindAllObjectsReactingToTemperature() {
        reactingToTemperature.Clear();
        IEnumerable<ITemperatureBehavior> objectsReacting = FindObjectsOfType<MonoBehaviour>().OfType<ITemperatureBehavior>();
        foreach (ITemperatureBehavior behavior in objectsReacting) {
            reactingToTemperature.Add(behavior);
        }
    }

}
