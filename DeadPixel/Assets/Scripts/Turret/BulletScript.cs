using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float damage = 1;

    private void OnCollisionEnter2D(Collision2D collider)
    {
        /*if (collider == GameObject.FindObjectOfType<BugInsect>().GetComponent<Collision2D>())
        {
            collider.gameObject.GetComponent<BugInsect>().MyHelth -= damage;
        }
        else if(collider == GameObject.FindObjectOfType<BugInsect1>().GetComponent<Collision2D>())
        {
            collider.gameObject.GetComponent<BugInsect1>().MyHelth -= damage;
        }
        else if(collider == GameObject.FindObjectOfType<BugInsect2>().GetComponent<Collision2D>())
        {
            collider.gameObject.GetComponent<BugInsect2>().MyHelth -= damage;
        }
        else if(collider == GameObject.FindObjectOfType<BugInsect3>().GetComponent<Collision2D>())
        {
            collider.gameObject.GetComponent<BugInsect3>().MyHelth -= damage;
        }
        else if(collider == GameObject.FindObjectOfType<BugInsect4>().GetComponent<Collision2D>())
        {
            collider.gameObject.GetComponent<BugInsect4>().MyHelth -= damage;
        }
        else
        {
            Destroy(gameObject);
        }*/
    }
    private void Awake()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait ()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
