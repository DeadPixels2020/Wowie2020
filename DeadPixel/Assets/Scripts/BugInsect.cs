using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugInsect : MonoBehaviour,IHitable
{
    public float MyHelth;
    float GiveDamadge;
    float speed;
    Player player;

    private void Awake()
    {
        MyHelth = 10;
        GiveDamadge = .5f;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
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
            player.PlayerHealth -= .5f;
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
