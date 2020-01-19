using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private int damageHp = 1;
    [SerializeField] private int damageSheelds = 1;

    private Damage damage;

    private void Start() {
        damage = new Damage(damageHp,damageSheelds,gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.CompareTag("Enemy")){
            IHealthDamager health = collider.gameObject.GetComponent<IHealthDamager>();
            if(health != null){
                health.TakeDamage(damage);
                StopAllCoroutines();
                Destroy(gameObject);
            }
        }
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
