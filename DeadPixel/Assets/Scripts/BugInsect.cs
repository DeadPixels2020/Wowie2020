﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugInsect : MonoBehaviour,IHitable
{
    float MyHelth;
    float GiveDamadge;
    float speed;
    GameManager gameManager;
    PlayerPocket pocket;

    private void Awake()
    {
        MyHelth = 10;
        GiveDamadge = .5f;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        pocket = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPocket>();
    }
    private void Update()
    {
        if (MyHelth <= 0)
        {
            Destroy(gameObject);
            //gameManager.addMat();
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Trap")
        {
            Destroy(gameObject);
            //gameManager.addMat();
        }
        if (col.gameObject.tag == "Player")
        {
            //gameManager.TakePlayerHelth();
            Destroy(gameObject);
        }
    }

    public void Hit(float dam)
    {
        MyHelth -= dam;
    }

    public float getHp()
    {
        return MyHelth;
    }
}
