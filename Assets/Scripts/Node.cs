using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;

public class Node : MonoBehaviour {
    public List<Node> connectedNodes = new List<Node>();
    public double G, H;
    public Node Parent;

    public string GetName() {
       return transform.name;
   }
   
   public void ConnectNodes() {
       foreach (Node node in connectedNodes) {
           if (node == null)
               connectedNodes.Remove(node);
           if (!node.connectedNodes.Contains(this)) {
               node.connectedNodes.Add(this);
               node.ConnectNodes();
           }
       }
   }
   
    private void OnDrawGizmos() {
        foreach (Node node in connectedNodes) {
            Gizmos.color = Color.red;
            if (node != null && node.connectedNodes.Contains(this))
                Gizmos.DrawLine(transform.position, node.transform.position);
        }
    }

}
