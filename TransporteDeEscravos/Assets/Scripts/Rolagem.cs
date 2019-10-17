using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolagem : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float velocidadeDeRolagem = -1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(velocidadeDeRolagem, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
