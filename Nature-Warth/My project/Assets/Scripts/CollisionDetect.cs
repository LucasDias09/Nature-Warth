// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CollisionDetect : MonoBehaviour
// {
    
//     private void OnTriggerEnter(Collider other)
//     {   
//         if(other.gameObject.tag == "Mushroom")
//         {
//             Destroy(gameObject); // Destruir o bot
//             Destroy(other.gameObject); // Destruir o Mushroom
            
//         }

//         if(other.gameObject.tag == "Champignon")
//         {
//             Destroy(other.gameObject); // Destruir o Mushroom
            
//         }
//     }



// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Champignon")
        {
            Destroy(other.gameObject); // Destruir o Mushroom

            
            NavMeshAgent navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
            
            if (navMeshAgent != null)
            {
                // Reduz a velocidade do bot para 2
                navMeshAgent.speed = 2f;
            }
        }
        
        if (other.gameObject.tag == "Mushroom")
        {
            Destroy(gameObject); // Destruir o bot
            Destroy(other.gameObject); // Destruir o Mushroom
        }
    }
}

