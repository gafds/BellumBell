﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
  
    public void Interacao()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>().InteractionButton_A();
    }
    public void InteracaoB()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>().InteractionButton_B();
    }
}