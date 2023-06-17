using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrunkWrath : MonoBehaviour
{
    private int trunkWrathCollisions = 0; // Contador de colisões com TrunkWrath

    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "Bot")
        {
            trunkWrathCollisions++; // Incrementar o contador de colisões com TrunkWrath

            Destroy(other.gameObject);  

            if (trunkWrathCollisions >= 3) // Verificar se ocorreram três colisões
            {
                Destroy(gameObject); 
                
            }
        }
    }



}
