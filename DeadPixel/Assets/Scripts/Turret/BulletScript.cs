using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private int damageHp = 1;
    [SerializeField] private int damageSheelds = 1;

    private Damage damage;

    AudioManager Audio;
    PlayerPocket pocket;

    private void Start() {
        damage = new Damage(damageHp,damageSheelds,gameObject);
        pocket = FindObjectOfType<PlayerPocket>();
        Audio = FindObjectOfType<AudioManager>();
        Audio.PlaySound("TurretShot1");
    }
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.CompareTag("Enemy")){
            IHealthDamager health = collider.gameObject.GetComponent<IHealthDamager>();
            if(health != null){
                health.TakeDamage(damage);
                StopAllCoroutines();
                pocket.AddToPocket(new Costs(2));
            }
        }
        Destroy(gameObject);
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
