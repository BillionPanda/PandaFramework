using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public float wallWidth = 10f;
    public float wallHeight = 3f;
    public float doorWidth = 2f;
    public float doorHeight = 2.5f;

    private MeshFilter meshFilter;

    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = new Material(Shader.Find("Universal Render Pipeline/Lit"));

        Mesh mesh = new Mesh();

        // Wall vertices
        Vector3[] vertices = new Vector3[]
        {
            // Left wall
            new Vector3(0, 0, 0), // bottom-left
            new Vector3(0, wallHeight, 0), // top-left
            new Vector3(wallWidth, wallHeight, 0), // top-right
            new Vector3(wallWidth, 0, 0), // bottom-right

            // Door vertices
            new Vector3((wallWidth - doorWidth) / 2, 0, 0), // door-bottom-left
            new Vector3((wallWidth - doorWidth) / 2, doorHeight, 0), // door-top-left
            new Vector3((wallWidth + doorWidth) / 2, doorHeight, 0), // door-top-right
            new Vector3((wallWidth + doorWidth) / 2, 0, 0), // door-bottom-right
        };

        // Wall triangles
        int[] triangles = new int[]
        {
            // Left part of the wall
            0, 1, 4, // lower-left triangle
            1, 5, 4, // upper-left triangle

            // Right part of the wall
            4, 5, 7, // lower-right triangle
            5, 6, 7, // upper-right triangle
        };

        // UV coordinates (placeholder)
        Vector2[] uv = new Vector2[vertices.Length];

        // Assign mesh data
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        mesh.RecalculateNormals(); // Ensure lighting works properly

        meshFilter.mesh = mesh;
    }
}
