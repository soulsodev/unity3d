using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    { 
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left Wall")
        {
            Debug.Log("Hit the LEFT WALL");
        }
        else if (collision.gameObject.name == "Right Wall")
        {
            Debug.Log("Hit the RIGHT WALL");
        }
        else if (collision.gameObject.name == "Back Wall")
        {
            Debug.Log("Hit the BACK WALL");
        }
        else
        {
            Debug.Log("Hit the FLOOR");
        }
    }
}
