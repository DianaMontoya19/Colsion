using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public GameObject Jugador;

    void Update()
    {
        transform.position = Jugador.transform.position + new Vector3(0f,1f,-2.3f);
    }
}
