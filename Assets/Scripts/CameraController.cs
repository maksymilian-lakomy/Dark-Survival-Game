using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    private Transform objectToFollow;

    [SerializeField]
    private bool shouldFollow = false;

    [SerializeField] private int toRound = 16;
    [SerializeField] private float followSpeed = 2f;

    private void Update() {
        Vector3 destinationPosition = objectToFollow.position;
        destinationPosition.z = transform.position.z;

        if (Vector3.Distance(transform.position, destinationPosition) >= .5f)
            shouldFollow = true;

        if (Vector3.Distance(transform.position, destinationPosition) <= .2f)
            shouldFollow = false;

        if (shouldFollow) {
            Vector3 newPosition = Vector3.Lerp(transform.position, destinationPosition, Time.deltaTime * followSpeed);
            // transform.position = newPosition;
            float xPos = Mathf.Round(newPosition.x * toRound) / toRound;
            float yPos = Mathf.Round(newPosition.y * toRound) / toRound;
            transform.position = new Vector3(xPos, yPos, transform.position.z);
        }

        
        
    }
}
