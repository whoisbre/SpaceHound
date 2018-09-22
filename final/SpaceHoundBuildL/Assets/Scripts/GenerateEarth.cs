using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter)), RequireComponent(typeof(MeshRenderer))]

public class GenerateEarth : MonoBehaviour {

    private Mesh mesh;
    private MeshRenderer meshR;
    private List<Vector3> vertices;
    private List<int> triangles;
    private List<Vector2> uvs;
    private GameObject turtle;
    private int vertcount;

	// Use this for initialization
	void Start ()
	{
	    turtle = GameObject.Find("Earth");
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
	    meshR = GetComponent<MeshRenderer>();
        turtle.transform.Translate(Vector3.down * 3);
        turtle.transform.Rotate(0, 180, 0);




        vertices = new List<Vector3>();
	    triangles = new List<int>();
        uvs = new List<Vector2>();
	    
        vertcount = 0;

	    for (int i = 0; i < 10000; i++)
	    {
	        createverts();
            createUvs();
	        turtle.transform.RotateAround(new Vector3(0, -1000, 0), Vector3.left, .36f);
	        createverts();
            createUvs();
	        turtle.transform.RotateAround(new Vector3(0, -1000, 0), Vector3.left, .36f);
	        vertcount += 12;
        }

	    createtriangles();
	    mesh.vertices = vertices.ToArray();
	    mesh.triangles = triangles.ToArray();
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        mesh.RecalculateTangents();

        



        mesh.SetUVs(0, uvs);

	   
	}

    void Update()
    {
        turtle.transform.RotateAround(meshR.bounds.center, new Vector3(1, 0, 0), -.36f);
    }





    void createverts()
    {
        vertices.Add(new Vector3(turtle.transform.position.x - 100f, turtle.transform.position.y - 15f + Random.Range(-3f, 3f), turtle.transform.position.z));
        vertices.Add(new Vector3(turtle.transform.position.x - 60f, turtle.transform.position.y - 12.5f + Random.Range(-8f, 8f), turtle.transform.position.z));
        vertices.Add(new Vector3(turtle.transform.position.x - 20f, turtle.transform.position.y - 10f + Random.Range(-10f, 10f), turtle.transform.position.z));
        vertices.Add(new Vector3(turtle.transform.position.x + 20f, turtle.transform.position.y - 10f + Random.Range(-10f, 10f), turtle.transform.position.z));
        vertices.Add(new Vector3(turtle.transform.position.x + 60f, turtle.transform.position.y - 12.5f + Random.Range(-8f, 8f), turtle.transform.position.z));
        vertices.Add(new Vector3(turtle.transform.position.x + 100f, turtle.transform.position.y - 15f + Random.Range(-3f, 3f), turtle.transform.position.z));
    }

    void createtriangles()
    {
        for (int i = 1; i <= vertcount/3; i += 6)
        {

            triangles.Add(i);
            triangles.Add(i + 6);
            triangles.Add(i + 1);

            triangles.Add(i+1);
            triangles.Add(i+6);
            triangles.Add(i+7);

            triangles.Add(i+1);
            triangles.Add(i+7);
            triangles.Add(i+8);

            triangles.Add(i+1);
            triangles.Add(i +8);
            triangles.Add(i + 2);

            triangles.Add(i+2);
            triangles.Add(i + 8);
            triangles.Add(i + 9);

            triangles.Add(i);
            triangles.Add(i + 4);
            triangles.Add(i + 5);

            triangles.Add(i+2);
            triangles.Add(i + 9);
            triangles.Add(i + 3);

            triangles.Add(i+3);
            triangles.Add(i + 9);
            triangles.Add(i + 10);

            triangles.Add(i+3);
            triangles.Add(i + 10);
            triangles.Add(i + 4);

            triangles.Add(i+4);
            triangles.Add(i + 10);
            triangles.Add(i + 11);

            triangles.Add(i+4);
            triangles.Add(i + 11);
            triangles.Add(i + 5);

        }
    }

    void createUvs()
    {
        uvs.Add(new Vector2(turtle.transform.position.x - 100f, turtle.transform.position.z));
        uvs.Add(new Vector2(turtle.transform.position.x - 60f, turtle.transform.position.z));
        uvs.Add(new Vector2(turtle.transform.position.x - 20f, turtle.transform.position.z));
        uvs.Add(new Vector2(turtle.transform.position.x + 20f, turtle.transform.position.z));
        uvs.Add(new Vector2(turtle.transform.position.x + 60f, turtle.transform.position.z));
        uvs.Add(new Vector2(turtle.transform.position.x + 100f, turtle.transform.position.z));
    }
}

// Author: Lukas Heitkamp
