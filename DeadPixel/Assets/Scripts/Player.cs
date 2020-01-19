using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider slider;

    public float PlayerHealth;
    private void Awake()
    {
        PlayerHealth = 10;
    }
}
