using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBug : MonoBehaviour
{
    private HealthHandler healthHandler;
    private void Awake() {
        healthHandler = GetComponent<HealthHandler>();
    }

    private void Start() {
        healthHandler.OnHealthBelowZero += Die;
    }

    private void Die(){
        Destroy(gameObject);
    }

    private void OnDestroy() {
        healthHandler.OnHealthBelowZero -= Die;
    }
}
