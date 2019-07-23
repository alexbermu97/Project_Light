using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //ESTE SCRIPT CONTROLA ÚNICAMENTE EL MOVIMIENTO DEL JUGADOR, TANTO CON MANDO COMO CON PANTALLA TÁCTIL
    public Rigidbody2D rb;
    public float speed;
    Vector2 movDir;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //BUSCA EN EL OBJETO QUE POSEA ESTE SCRIPT EL COMPONENTE RIGIDBODY2D Y LO ASIGNA A LA VARIABLE
    }
    
    void Update()
    {
        ControllerMove();
    }

    void ControllerMove()
    {
        //Mando
        float hc = Input.GetAxis("HorizontalC");
        float vc = Input.GetAxis("VerticalC");

        movDir = (hc * transform.right + vc * transform.up); //ACTUALIZA VECTOR MOVDIR
        rb.velocity = movDir * speed * Time.deltaTime; //ACTUALIZA VECTOR VELOCITY, QUE SE APLICA AL RIGIDBODY2D Y PERMITE MOVIMIENTO
        //MandoFin
    }
}
