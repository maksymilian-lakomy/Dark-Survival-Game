using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BehaviorInterfaces;
using UnityEngine;

public class WeatherController : MonoBehaviour {
    private List<ITemperatureBehavior> reactingToTemperature = new List<ITemperatureBehavior>();

    private void Awake() {
        FindAllObjectsReactingToTemperature();
        InvokeRepeating(nameof(TemperatureAction), 0, 1f);
    }
    
    private void FindAllObjectsReactingToTemperature() {
        reactingToTemperature.Clear();
        IEnumerable<ITemperatureBehavior> objectsReacting = FindObjectsOfType<MonoBehaviour>().OfType<ITemperatureBehavior>();
        foreach (ITemperatureBehavior behavior in objectsReacting) {
            reactingToTemperature.Add(behavior);
        }
    }

    private void TemperatureAction() {
        foreach (ITemperatureBehavior objectReacting in reactingToTemperature) {
            objectReacting.TemperatureChange(-.25f);
        }
    }
}
