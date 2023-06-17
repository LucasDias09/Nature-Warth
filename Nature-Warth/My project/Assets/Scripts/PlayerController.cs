using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public string targetObjectTag; // Tag of the target object

    private GameObject targetObject; // Reference to the target object

    void Start()
    {
        FindNearestTarget();
    }

    void Update()
    {
        if (targetObject != null)
        {
            agent.SetDestination(targetObject.transform.position);
        }
        else
        {
            FindNearestTarget();
        }
    }

    void FindNearestTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetObjectTag);
        if (targets.Length > 0)
        {
            float shortestDistance = Mathf.Infinity;
            GameObject nearestTarget = null;

            foreach (GameObject target in targets)
            {
                float distance = Vector3.Distance(transform.position, target.transform.position);
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearestTarget = target;
                }
            }

            targetObject = nearestTarget;
        }
        else
        {
            // Debug.LogWarning("No target objects found with tag: " + targetObjectTag);
            // SceneManagementceneManager.LoadScene("SceneManager.GetActiveScene().buildIndex = 1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
