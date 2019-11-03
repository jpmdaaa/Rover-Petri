using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexDijkstras : MonoBehaviour
{
    public string Name;
    public int status;
    public int predecessor;
    public int pathLength;
   
   public VertexDijkstras(string Name)
    {
        this.Name = Name;
    }
}
