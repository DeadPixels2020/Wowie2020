using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider slider;

    public float PlayerHealth;
    private void Update()
    {
        PlayerHealth = 10;
        slider.value = PlayerHealth / 10;
    }
}
