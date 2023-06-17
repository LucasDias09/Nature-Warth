using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Mushroom")
        {
            Destroy(gameObject); // Destruir o bot
            Destroy(other.gameObject); // Destruir o Mushroom
        }
    }

}
