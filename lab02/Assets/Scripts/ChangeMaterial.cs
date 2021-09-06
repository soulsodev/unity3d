using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    Material material;
    Color startMaterialColor;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startMaterialColor = material.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (material.color == startMaterialColor)
            {
                material.color = Color.green;
            }
            else
            {
                material.color = startMaterialColor;
            }
            
        }
    }
}

