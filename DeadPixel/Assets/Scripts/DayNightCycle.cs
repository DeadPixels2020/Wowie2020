using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
[RequireComponent(typeof(Light2D))]
public class DayNightCycle : MonoBehaviour
{
    int currentNight;

    private Light2D _light;
    [SerializeField] private float chengScale;
    [SerializeField] private bool invert;

    [SerializeField] private bool SunriseIfNoEnemiesLeft;
    [SerializeField] private EnemySpawner spawner;

    private bool isDay;
    private float chengIntensityTo;
    
    private IDayNightSeter dayNightSeter;

    public bool IsDay { get => isDay;}

    private void Awake()
    {
        _light = GetComponent<Light2D>();
        chengIntensityTo = 0;
        dayNightSeter = GameEvents.instance;
    }

    private void Update()
    {
        _light.intensity = Mathf.Lerp(_light.intensity,chengIntensityTo,Time.deltaTime * chengScale);
        
        if(_light.intensity < 0.001f){
            if(SunriseIfNoEnemiesLeft){
                if(spawner.AreAllEnemiesDead()) StartSunrise();
            }else{
                StartSunrise();
            }

        }

        if(_light.intensity > 0.998f)
        {
            StartSunset();
        }

        isDay = _light.intensity > .5f;
    }

    private void StartSunrise(){
        chengIntensityTo = 1;
        if(dayNightSeter != null) dayNightSeter.onGettingBrighter();
    }

    private void StartSunset(){
        chengIntensityTo = 0;
        if(dayNightSeter != null) dayNightSeter.onGettingDark();
    }

}
