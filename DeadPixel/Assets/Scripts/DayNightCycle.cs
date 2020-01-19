using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
[RequireComponent(typeof(Light2D))]
public class DayNightCycle : MonoBehaviour
{
    public int CurrentNight;
    public float timer;

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
        CurrentNight = 0;
    }

    private void Update()
    {
        _light.intensity = Mathf.Lerp(_light.intensity,chengIntensityTo,Time.deltaTime * chengScale);
        
        if(_light.intensity < 0.001f)
        {
            if (spawner.AreAllEnemiesDead())
            {
                StartSunrise();
                CurrentNight += 1;
                timer = 15;
            }

        }
        timer -= 1 * Time.deltaTime;
        if (_light.intensity > 0.998f)
        {
            if (timer <= 0)
            {
                StartSunset();
                spawner.StartSpawning();
            }
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
