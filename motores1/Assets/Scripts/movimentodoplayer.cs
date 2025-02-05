using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimentodoplayer : MonoBehaviour
{
    public float velocidadeDoJogador;
    public float alturaDoPulo;

    public Rigidbody2D oRigidbody2D;

    public SpriteRenderer oSpriteRenderer;

    public bool estaNoChao;
    public Transform VerificadorDeChao;
    public float raioDeVerificacao;
    public LayerMask layerDoChao;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        MovimentarJogador();
        Pular();
    }


    public void MovimentarJogador()
    {
        float inputDoMovimento = Input.GetAxisRaw("Horizontal");
        oRigidbody2D.velocity = new Vector2(inputDoMovimento * velocidadeDoJogador, oRigidbody2D.velocity.y);

        if (inputDoMovimento > 0)
        {
            oSpriteRenderer.flipX = false;
        }

        if (inputDoMovimento < 0)
        {
            oSpriteRenderer.flipX = true;
        }
    }

    public void Pular()
    {
        estaNoChao = Physics2D.OverlapCircle(VerificadorDeChao.position, raioDeVerificacao, layerDoChao);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}


