using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    Vector2 movDir;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Move();
    }

    void Move()
    {
        //Mando
        float hc = Input.GetAxis("HorizontalC");
        float vc = Input.GetAxis("VerticalC");

        movDir = (hc * transform.right + vc * transform.up);
        rb.velocity = movDir * speed * Time.deltaTime;
        //MandoFin
    }
}
