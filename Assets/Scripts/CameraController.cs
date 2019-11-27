using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    private PlayerController objectToFollow;

    [SerializeField]
    private bool shouldFollow = false;

    [SerializeField] private float followSpeed = 2f;

    private void Update() {
        Vector3 destinationPosition = objectToFollow.transform.position;
        destinationPosition.z = transform.position.z;

        if (Vector3.Distance(transform.position, destinationPosition) >= .5f)
            shouldFollow = true;

        if (shouldFollow && !objectToFollow.IsMoving && Vector3.Distance(transform.position, destinationPosition) < 0.5f)
            shouldFollow = false;

        if (shouldFollow) {
            transform.position = Vector3.Lerp(transform.position, destinationPosition, Time.deltaTime * followSpeed);
            // // transform.position = newPosition;
            // float xPos = Mathf.Round(newPosition.x * toRound) / toRound;
            // float yPos = Mathf.Round(newPosition.y * toRound) / toRound;
            // transform.position = new Vector3(xPos, yPos, transform.position.z);
        }

        
        
    }
}
