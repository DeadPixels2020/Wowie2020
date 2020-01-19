using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugInsect2 : MonoBehaviour,IHitable
{
    float MyHelth;
    GameManager gameManager;
    GameObject GaMan;

    private void Awake()
    {
        MyHelth = 30;
        GaMan = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = GaMan.GetComponent<GameManager>();
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
