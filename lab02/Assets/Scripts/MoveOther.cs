using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOther : MonoBehaviour
{
    public GameObject blueCube;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, blueCube.transform.position, Time.deltaTime);
    }
}
