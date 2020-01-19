using System;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour,IHealthDamager,IHealthHealer
{
    [SerializeField] private Stats stats;

    private int hp;
    private int sheelds;

    private void Start() {
        hp = stats.HP;
        sheelds = stats.Sheelds;
    }

    public void Heal(HealAmount heal)
    {
        hp += heal.HP;
        sheelds += heal.Sheelds;

        if(hp > stats.HP) hp = stats.HP;
        if(sheelds > stats.Sheelds) sheelds = stats.Sheelds;

        if(OnStatsChenged != null) OnStatsChenged(new Stats(hp,sheelds));
    }

    public void TakeDamage(Damage damage)
    {
        hp -= damage.HP;
        sheelds -= damage.Sheelds;

        if(sheelds < 0) sheelds = 0;

        if(OnStatsChenged != null) OnStatsChenged(new Stats(hp,sheelds));

        if(hp < 0 && OnHealthBelowZero != null) OnHealthBelowZero(); 
    }

    public event Action<Stats> OnStatsChenged;
    public event Action OnHealthBelowZero;

    
}
