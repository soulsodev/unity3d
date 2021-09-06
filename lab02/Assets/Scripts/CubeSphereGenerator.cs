using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphereGenerator : MonoBehaviour
{
    new MeshRenderer renderer;
    float minX, maxX, minZ, maxZ, newX, newY, newZ;
    GameObject cube;
    GameObject sphere;
    Material material;

    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();

        minX = renderer.bounds.min.x;
        maxX = renderer.bounds.max.x;
        minZ = renderer.bounds.min.z;
        maxZ = renderer.bounds.max.z;
    }

    void Update()
    {
        newX = Random.Range(minX, maxX);
        newZ = Random.Range(minZ, maxZ);
        newY = gameObject.transform.position.y + Random.Range(1, 10);

        if (Input.GetKeyDown (KeyCode.Space))
        {
            addCube(newX, newY, newZ);
        }

        if (Input.GetMouseButtonDown(0))
        {
            addSphere(newX, newY, newZ);
        }
    }

    void addCube(float newX, float newY, float newZ)
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(newX, newY, newZ);
        material = cube.GetComponent<Renderer>().material;
        material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        cube.AddComponent<Rigidbody>();
    }

    void addSphere(float newX, float newY, float newZ)
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(newX, newY, newZ);
        material = sphere.GetComponent<Renderer>().material;
        material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        sphere.AddComponent<Rigidbody>();
    }
}
