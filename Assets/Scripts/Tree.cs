using BehaviorInterfaces;
using DefaultNamespace;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Tree : MonoBehaviour, IDurabilityBehavior, IActive {

    private SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
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

    public void SetActive(bool active) {
        if (active) {
            Material material = spriteRenderer.material;
            material.SetFloat("_Glow", 1);
        } else {
            Material material = spriteRenderer.material;
            material.SetFloat("_Glow", 0);
        }
            
    }
}
