using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetir : MonoBehaviour
{

    private BoxCollider2D chaoCollider;
    private float tamanhoDoChao;

    private void Awake()
    {
        chaoCollider = GetComponent<BoxCollider2D>();
        tamanhoDoChao = chaoCollider.size.x;
   
    }

    private void Update()
    {
        if (transform.position.x < -tamanhoDoChao)
        {
            ReposicionandoChao();
        }
    }

    private void ReposicionandoChao()
    {
        Vector2 groundOffSet = new Vector2(tamanhoDoChao * 2f, 0);
        transform.position = (Vector2)
        transform.position + groundOffSet;
    }
}
