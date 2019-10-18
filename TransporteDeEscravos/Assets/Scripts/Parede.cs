﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour
{

    private Jogo jogo;


    private void Start()
    {
        GameObject objetoJogo = GameObject.FindWithTag("JOGO");
        jogo = objetoJogo.GetComponent<Jogo>();
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {



        if (colisor.gameObject.tag == "Player")
        {
            colisor.gameObject.transform.Translate(-Vector2.right);
            jogo.DiminuirVida();

        }


    }






}
