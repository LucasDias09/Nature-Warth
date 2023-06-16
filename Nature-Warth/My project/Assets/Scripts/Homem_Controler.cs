using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homem_Controler : MonoBehaviour
{
    public float HorizontalInput;
    public Transform targetObject;//referência ao objeto de destino
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -10){
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

          //Calcula a direção para o objeto de destino
        Vector3 direction = targetObject.position - transform.position;
        direction.Normalize(); //normaliza o vetor de direção para que a magnitude seja 1

        //Move o objeto na direção do objeto de destino
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
