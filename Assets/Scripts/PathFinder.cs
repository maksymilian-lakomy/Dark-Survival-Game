using System;
using System.Collections;
using System.Collections.Generic;
using Priority_Queue;
using UnityEngine;

public static class PathFinder
{
    private static Queue<Node> ReconstructPath(Dictionary<string,Node> closed,Node origin,Node end) {
        Queue<Node> path = new Queue<Node>();
        List<Node> trace = new List<Node>();

        Node current = end;
        trace.Add(current);

        while(current != origin) {
            current = closed[current.Parent.GetName()];
            trace.Add(current);
        }

        for (int i = trace.Count -1; i >= 0; i--) {
            path.Enqueue(trace[i]);
        }
        return path;
    }

    public static double Distance(Node a,Node b)
    {
        Vector3 positionA = a.transform.position;
        Vector3 positionB = b.transform.position;
            
        return Math.Sqrt(Math.Pow(positionA.x - positionB.x, 2) + Math.Pow(positionA.y - positionB.y, 2));
    }

    public static Queue<Node> FindPath(Node origin,Node destination) 
    {
        Dictionary<string,Node> closed = new Dictionary<string,Node>();
        SimplePriorityQueue <Node,double> open = new SimplePriorityQueue<Node,double>();
            
        Debug.Log(origin);
        Debug.Log(destination);

        open.Enqueue(origin,0);

        while(open.Count > 0)
        {
            Node current = open.Dequeue();

            if(current == destination) {
                return ReconstructPath(closed,origin, current ); //reconstruct path
            }

            closed.Add(current.GetName(),current);

            foreach (Node n in current.connectedNodes) {
                    
                if (closed.ContainsKey(n.GetName()))
                    continue;

                n.G = current.G + Distance(current, n);
                bool neighbourIsBetter = false;


                if (!open.Contains(n)) {
                    n.H = Distance(n, destination);
                    open.Enqueue(n, n.H);
                    neighbourIsBetter = true;
                } else if (n.G < current.G) {
                    neighbourIsBetter = true;
                }

                if (neighbourIsBetter) {
                    n.Parent = current;
                    open.Enqueue(n, n.H + n.G);
                }
            }
        }
        throw new Exception("path not found");
    }
}