using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour {
    
    [SerializeField]
    public List<Node> Nodes = new List<Node>();

    public static NodeManager i;
    
    private void Awake() {
        if (i == null)
            i = this;
        else
            Destroy(gameObject);
        GameObject[] nodes = GameObject.FindGameObjectsWithTag("Node");
        foreach (GameObject node in nodes) {
            Nodes.Add(node.GetComponent<Node>());
        }
    }
    
    public Node FindNearestNode(Vector2 position) { 
        Node nearestNode = Nodes[0];
        foreach (Node node in Nodes) {
            float distanceToCheck = Vector2.Distance(position, node.transform.position);
            if (distanceToCheck < Vector2.Distance(position, nearestNode.transform.position))
                nearestNode = node;
        }
        return nearestNode;
    }
}
