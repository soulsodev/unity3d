using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleWork : MonoBehaviour
{
    public string name = "Vladislav";

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        print($"{name} is studying Unity!");
    }
}
