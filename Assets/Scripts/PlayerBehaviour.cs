﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public CharacterController controle;
    public Transform cam;
    public float velocidade,velocidadeAtual;
    public float tempoSuavidade;
    float tornarSuave;
    void Start()
    {
        velocidadeAtual = velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
    }
    void Movimentacao()
    {
      Vector3 movement = Vector3.zero;
      float v = Input.GetAxis("Vertical");
      float h = Input.GetAxisRaw("Horizontal");
      velocidadeAtual =Input.GetKey(KeyCode.LeftShift)? velocidade*2f:velocidade;
      transform.Rotate(Vector3.up *h *velocidadeAtual/(velocidade +30));
      transform.GetComponent<Animator>().SetFloat("Velocidade",controle.velocity.magnitude);
      movement += transform.forward * v * velocidadeAtual * Time.deltaTime;
      controle.Move(movement);
      //movement += transform.right * h * velocidade * Time.deltaTime;
      //movement = transform.TransformDirection(movement);
      movement += Physics.gravity;
      
    }
}
