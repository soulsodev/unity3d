using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindWay : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    public Transform target;

    void Start()
    {
     agent.SetDestination (target.position);   
    }

    void Update()
    {
        
    }
}
