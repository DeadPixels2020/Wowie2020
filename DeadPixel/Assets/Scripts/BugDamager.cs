using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugDamager : MonoBehaviour
{
    [SerializeField] private int damageHp;
    [SerializeField] private int damageSheelds;
    

    private Damage damage;

    private void Start() {
        damage= new Damage(damageHp,damageSheelds,gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            IHealthDamager health = other.gameObject.GetComponent<IHealthDamager>();

            if(health != null){
                health.TakeDamage(damage);
                Suicide();
            }
        }
    }

    private void Suicide(){
        Destroy(gameObject);
    }

}
