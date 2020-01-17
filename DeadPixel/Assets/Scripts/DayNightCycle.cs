using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
[RequireComponent(typeof(Light2D))]
public class DayNightCycle : MonoBehaviour
{
    private Light2D _light;
    [SerializeField] private float chengScale;
    [SerializeField] private bool invert;

    private bool isDay;
    private float chengIntensityTo;

    private void Awake() {
        _light = GetComponent<Light2D>();
        chengIntensityTo = 0;
        isDay = true;
    }

    private void Update() {
        _light.intensity = Mathf.Lerp(_light.intensity,chengIntensityTo,Time.deltaTime * chengScale);

        if(_light.intensity < 0.01){
            isDay = false;
            chengIntensityTo = 1;
        }else if(_light.intensity >= 9.98){
            isDay = true;
            chengIntensityTo = 0;
        }
    }

}
