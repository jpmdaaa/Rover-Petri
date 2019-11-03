using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dijkstras : MonoBehaviour
{
    public readonly int Max_VERTICES = 30;
    int n;
    int e;
    int[,] adj;
    VertexDijkstras[] vertexList;

    private readonly int TEMPORARY = 1;
    private readonly int PERMANENT = 2;
    private readonly int NIL = -1;
    private readonly int INFINITY = 99999;

    public Dijkstras()
    {
        adj = new int[Max_VERTICES, Max_VERTICES];
        vertexList = new VertexDijkstras[Max_VERTICES];

    }

    private void Dijkstra(int s)
    {
        int v, c;

        for (v=0;v<n;v++)
        {
            vertexList[v].status = TEMPORARY;
            vertexList[v].pathLength = INFINITY;
            vertexList[v].predecessor = NIL;
        }

        vertexList[s].pathLength = 0;

        while(true)
        {
            c = TempVertexMinPL();
            if (c == NIL)
                return;

            vertexList[c].status = PERMANENT;

            for(v=0;v<n;v++)
            {
                if(vertexList[v].status==TEMPORARY)
                {
                    if(vertexList[c].pathLength +adj[c,v]<vertexList[v].pathLength)
                    {
                        vertexList[v].predecessor = c;
                        vertexList[v].pathLength = vertexList[c].pathLength + adj[c, v];
                    }
                }
            }

        }

    }

    private int TempVertexMinPL()
    {
        int min = INFINITY;
        int x = NIL;

        for (int v=0;v<n;v++)
        {
            if(vertexList[v].status== TEMPORARY && vertexList[v].pathLength<min)
            {
                min = vertexList[v].pathLength;
                x = v;
            }
        }
        return x;
    }

    public void FindPaths(string souce)
    {
        int s = GetIndex(souce);
        Dijkstra(s);

        Debug.Log("Source Vertex: " + souce);

        for(int v=0; v<n; v++)
        {
            Debug.Log("Destination Verxtex : " + vertexList[v].name);
            if (vertexList[v].pathLength == INFINITY)
            {
                Debug.Log("There is no path from" + souce + "to vertex" + vertexList[v].name);

            }
            else
                FindPath(s, v);
        }
        
    }

    private void FindPath(int s, int v)
    {
        int i, u;
        int[] path = new int[n];
        int sd = 0;
        int count = 0;

        while(v!=s)
        {
            count++;
            path[count] = v;
            u = vertexList[v].predecessor;
            sd += adj[u, v];
            v = u;
        }

        count++;
        path[count] = s;

        Debug.Log("Shortest Path is: ");

    }

    private int GetIndex (string s)
    {
        for (int i=0; i<n; i++)
        {
            if(s.Equals(vertexList[i].name))
            {
                return i;
            }
           
        }
        throw new System.InvalidOperationException("Invalid Vertex");
    }

    public void InsertVertex(string name)
    {
        
    }
}
