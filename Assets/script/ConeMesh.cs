using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeMesh : MonoBehaviour
{
    void Start()
    {
        var mesh = new Mesh();
        float theta;
        float r = Data.range * Mathf.Sqrt(1 - Data.cosAlpha * Data.cosAlpha) / Data.cosAlpha;
        Vector3[] point = new Vector3[13];
        point[0] = new Vector3(0f, Data.range, 0f);
        for (int i = 1; i < 13; i++)
        {
            theta = (i - 1) * Mathf.PI / 6f;
            point[i] = new Vector3(r * Mathf.Cos(theta), 0f, r * Mathf.Sin(theta));
        }
        mesh.SetVertices(point);
        mesh.SetTriangles(new int[]
        {
            2,1,0,
            3,2,0,
            4,3,0,
            5,4,0,
            6,5,0,
            7,6,0,
            8,7,0,
            9,8,0,
            10,9,0,
            11,10,0,
            12,11,0,
            1,12,0
        }, 0);
        var filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;
    }
        
}
