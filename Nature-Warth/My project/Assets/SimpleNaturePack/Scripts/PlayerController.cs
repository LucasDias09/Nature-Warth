using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public string targetObjectName; // Name of the target object

    void Start()
    {
        GameObject targetObject = GameObject.Find(targetObjectName);
        if (targetObject != null)
        {
            agent.SetDestination(targetObject.transform.position);
        }
        else
        {
            Debug.LogWarning("Target object not found!");
        }
    }
}

