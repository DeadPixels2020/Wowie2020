using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugDamager : MonoBehaviour
{
    [SerializeField] private int damageHp;
    [SerializeField] private int damageSheelds;
    [SerializeField] private float attackRate;
    

    private Damage damage;
    private float attackTimer;
    private bool isReadyToAttak;

    private void Start() {
        damage= new Damage(damageHp,damageSheelds,gameObject);
    }

    private void Update() {
        if(!isReadyToAttak){

            attackTimer += Time.deltaTime;

            if(attackTimer >= attackRate){
                isReadyToAttak = true;
                attackTimer = 0;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            IHealthDamager health = other.gameObject.GetComponent<IHealthDamager>();

            if(isReadyToAttak && health != null)
            {
                health.TakeDamage(damage);
                isReadyToAttak = false;
                PlayerPocket.Pocket.AddToPocket(new Costs(2000));
            }
        }
    }

}
