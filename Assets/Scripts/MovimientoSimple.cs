using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSimple : MonoBehaviour
{
     public float velocidad = 5f;
  
    void Update()
    {
        //Obtener la entrada del teclado
        // vas a unity edit project setting, input manager and axes

        float movimientoHor = Input.GetAxis("Horizontal");
        float movimientoVer = Input.GetAxis("Vertical");
        //calcular la direccion del movimiento

        Vector3 movimiento = new Vector3(movimientoHor, 0f , movimientoVer);

        //Aplicarle el movimiento al jugador
        GetComponent<Rigidbody>().velocity = movimiento*velocidad;
       
    }
}
