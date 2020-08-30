using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    void Start()
    {
        mesh= new Mesh();
        GetComponent<MeshFilter>().mesh=mesh;
        CreateShape();
        UpdateMesh();
    }

    void Update()
    {
        DrawLine();
    }

    void CreateShape()
    {        
        vertices= new Vector3[]
        {
            new Vector3 (0,0,0),
            new Vector3 (0,0,2),
            new Vector3 (2,0,0),
            new Vector3 (2,0,2),

            new Vector3 (0,2,0),
            new Vector3 (0,2,2),
            new Vector3 (2,2,0),
            new Vector3 (2,2,2),

            new Vector3 (4,1,2),
            new Vector3 (4,1,0)
            
        };
        triangles= new int[]
        {
            2,1,0,
            2,3,1,

            4,5,6,
            5,7,6,

            1,4,0,
            1,5,4,

            0,4,2,
            2,4,6,

            3,5,1,
            7,5,3,

            6,7,9,
            9,7,8,

            9,3,2,
            8,3,9,

            2,6,9,

            8,7,3

        };
    }

    void DrawLine()
    {
        var color= Color.black;
        Debug.DrawLine(vertices[0],vertices[2],color);
        Debug.DrawLine(vertices[2],vertices[3],color);
        Debug.DrawLine(vertices[3],vertices[1],color);
        Debug.DrawLine(vertices[1],vertices[0],color);

        Debug.DrawLine(vertices[0],vertices[4],color);
        Debug.DrawLine(vertices[2],vertices[6],color);
        Debug.DrawLine(vertices[3],vertices[7],color);
        Debug.DrawLine(vertices[1],vertices[5],color);

        Debug.DrawLine(vertices[4],vertices[5],color);
        Debug.DrawLine(vertices[5],vertices[7],color);
        Debug.DrawLine(vertices[7],vertices[6],color);
        Debug.DrawLine(vertices[6],vertices[4],color);

        Debug.DrawLine(vertices[6],vertices[9],color);
        Debug.DrawLine(vertices[2],vertices[9],color);
        Debug.DrawLine(vertices[7],vertices[8],color);
        Debug.DrawLine(vertices[3],vertices[8],color);
        Debug.DrawLine(vertices[8],vertices[9],color);
    }

    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices=vertices;
        mesh.triangles=triangles;
    }
}
