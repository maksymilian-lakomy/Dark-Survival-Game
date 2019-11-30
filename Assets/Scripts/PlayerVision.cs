using System;
using UnityEngine;

namespace DefaultNamespace {
    public class PlayerVision: MonoBehaviour {


        [SerializeField] private Vector3 eyesPosition;
        [SerializeField] private float viewDistance = 1f;

        [SerializeField] private GameObject currentActive;
        
        
        private void FixedUpdate() {
            RaycastHit2D hit = Physics2D.Raycast(transform.position + eyesPosition, transform.right * viewDistance);
            if (hit.collider != null) {
                GameObject newActive = hit.collider.gameObject;
                if (newActive != currentActive) {
                    currentActive = newActive;
                }
            }
            Debug.DrawRay(transform.position + eyesPosition, transform.right*viewDistance, Color.red);
        }


    }
}