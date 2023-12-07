using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejoColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Jugador"))
        {
            Desaparecer();
        }

        void Desaparecer()
        {
            Destroy(gameObject);
        }



    }

}
