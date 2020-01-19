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
    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision == GameObject.FindGameObjectWithTag("Enemy").GetComponent<Collider2D>())
        {
            slider.value = PlayerHealth / 10;
        }
    }
}
