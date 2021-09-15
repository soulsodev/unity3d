using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube" || collision.gameObject.tag == "Sphere")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Cactus")
        {
            Destroy(gameObject);
        }
    }
}
