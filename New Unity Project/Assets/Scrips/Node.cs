using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    public int gridX;
    public int gridY;

    public bool isWall;
    public Vector3 position;

    public Node parent;

    public int gCost, hCost;
    public int FCost { get { return gCost + hCost; } }

    public Node(bool a_isWall, Vector3 a_pos, int a_gridX, int a_gridY)
    {
        isWall = a_isWall;
        position = a_pos;
        gridX = a_gridX;
        gridY = a_gridY;
    }
}