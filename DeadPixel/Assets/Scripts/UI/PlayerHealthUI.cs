using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{

    [SerializeField] private HealthHandler playerHealth;
    [SerializeField] private Slider healthSlider;

    private void Start() {
        playerHealth.OnStatsChenged += UpdateHealthUI;
        UpdateHealthUI(playerHealth.maxStats);
    }

    private void UpdateHealthUI(Stats curentStats){
        float healthNormolised =(float) curentStats.HP/(float) playerHealth.maxStats.HP;
        
        //healthNormolised = Mathf.Clamp(0f,1f,healthNormolised);
        healthSlider.SetValueWithoutNotify(healthNormolised);

    }

    private void OnDestroy() {
        playerHealth.OnStatsChenged -= UpdateHealthUI;
    } 
}
