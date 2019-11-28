using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NodeManager))]
public class NodeManagerEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        NodeManager manager = (NodeManager) target;

        if (GUILayout.Button("find path")) {
            Queue<Node> path = PathFinder.FindPath(manager.Origin, manager.Destination);

            while (path.Count > 0) {
                Debug.Log(path.Dequeue());
            }
        }
    }
}