using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentodoplayer : MonoBehaviour
{
    public float velocidadeDoJogador;

    public Rigidbody2D oRigidbody2D;
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
    }
    

    public void MovimentarJogador()
    {
        float inputDoMovimento = Input.GetAxisRaw("Horizontal");
        oRigidbody2D.velocity = new Vector2(inputDoMovimento * velocidadeDoJogador, oRigidbody2D.velocity.y);
    }
}
