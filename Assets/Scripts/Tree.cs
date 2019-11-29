using BehaviorInterfaces;
using UnityEngine;

public class Tree : MonoBehaviour, IDurabilityBehavior {

    [SerializeField]
    private float durability;

    public float Durability => durability;
    
    public void DurabilityChange(float change) {
        durability -= change;
        DurabilityLogic();
    }

    private void DurabilityLogic () {
        if (durability <= 0)
            Destroy(gameObject);
    }
}
