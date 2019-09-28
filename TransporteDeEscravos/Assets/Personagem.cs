using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float velocidade = 4;
    public bool olhandoParaDireita = true;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Mover()
    {
        float horizontalForceButton = Input.GetAxis ("Horizontal");
        rb.velocity = new Vector2 (horizontalForceButton * velocidade, rb.velocity.y);
    }

    void Update()
    {
        Mover();
    }
}
