using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Node))]
public class NodeEditor : Editor {
    
    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        Node node = (Node) target;
        if (GUILayout.Button("Connect nodes"))
            node.ConnectNodes();
    }
}
