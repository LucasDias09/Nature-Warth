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
            
            int amountToAdd = 1; //Quantidade de gold que retira
            FindObjectOfType<Economy>().AddGold(amountToAdd); //Função que retira o gold

            NavMeshAgent navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
            
            if (navMeshAgent != null)
            {
                // Reduz a velocidade do bot para 2
                navMeshAgent.speed = 2;
            }
        }
        
        if (other.gameObject.tag == "Mushroom")
        {
            int amountToAdd = 2; //Quantidade de gold que retira
            FindObjectOfType<Economy>().AddGold(amountToAdd); //Função que retira o gold
            Destroy(gameObject); // Destruir o bot
            Destroy(other.gameObject); // Destruir o Mushroom
        }
        if(other.gameObject.tag == "TrunkWrath")
        {
            var maceCout = FindObjectOfType<amoutCountTrunk>();
            int maceBalance = maceCout.GetAmoutBalance();
            int amountToAdd = 2; //Quantidade de gold que retira
            FindObjectOfType<Economy>().AddGold(amountToAdd); //Função que retira o gold

            if (maceBalance == 3) 
            {
            Destroy(gameObject); // Destruir o bot
            Destroy(other.gameObject); // Destruir o Mushroom
            }
            
            else{
            FindObjectOfType<Economy>().AddGold(amountToAdd); //Função que retira o gold
            FindObjectOfType<amoutCountTrunk>().AddAmout(1);
            }
        }
    }
}

