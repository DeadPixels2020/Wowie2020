using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour, IHealthDamager, IHealthHealer
{
    [SerializeField] private Stats stats;
    public Stats maxStats { get => stats; }
    private int hp;
    private int sheelds;
    public UIPlaySceneManager UI;
    public Slider HealthSlider;

    private void Start()
    {
        hp = stats.HP;
        sheelds = stats.Sheelds;
    }

    public void Heal(HealAmount heal)
    {
        hp += heal.HP;
        sheelds += heal.Sheelds;

        if (hp > stats.HP) hp = stats.HP;
        if (sheelds > stats.Sheelds) sheelds = stats.Sheelds;

        if (OnStatsChenged != null) OnStatsChenged(new Stats(hp, sheelds));
    }

    public void TakeDamage(Damage damage)
    {
        hp -= damage.HP;
        sheelds -= damage.Sheelds;

        if (sheelds < 0) sheelds = 0;

        if (OnStatsChenged != null) OnStatsChenged(new Stats(hp, sheelds));

        if (hp < 0 && OnHealthBelowZero != null)
            OnHealthBelowZero();
        //HealthSlider.value = 
        if (hp <= 0)
        {
            UI.OpenDeth();
            Destroy(gameObject);
        }
    }

    public event Action<Stats> OnStatsChenged;
    public event Action OnHealthBelowZero;



}
