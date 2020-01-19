using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    [SerializeField] private GameObject explosion;
    [SerializeField] private float range;
    [SerializeField] private Stats damage;
    
    [SerializeField] private LayerMask enemyMask;

    private bool boom;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(!boom && col.collider.CompareTag("Enemy")){   
            boom = true;
            StartCoroutine(StartExplosion());
        }
    }

    private IEnumerator StartExplosion(){
        Instantiate(explosion,transform.position, Quaternion.identity);

        yield return new WaitForEndOfFrame();

        CastExplosin();
        Destroy(gameObject);
    }

    private void CastExplosin(){
        Collider2D[] col = Physics2D.OverlapCircleAll(transform.position, range,enemyMask);

        foreach(Collider2D collider in col){
            if(collider.CompareTag("Enemy")){
                IHealthDamager hitable = collider.gameObject.GetComponent<IHealthDamager>();

                if(hitable != null)
                {
                    hitable.TakeDamage(new Damage(damage.HP,damage.Sheelds,gameObject));
                }

            }

        }
    }
}
