﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
[RequireComponent(typeof(Light2D))]
public class DayNightCycle : MonoBehaviour
{
    public AudioManager au;

    int currentNight;
    public int CurrentNight{get => currentNight;}
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
        chengIntensityTo = 1;
        dayNightSeter = GameEvents.instance;
        currentNight = 0;
        timer = 20;
    }

    private void Update()
    {
        _light.intensity = Mathf.Lerp(_light.intensity,chengIntensityTo,Time.deltaTime * chengScale);
        
        if(_light.intensity < 0.001f)
        {
            if (spawner.AreAllEnemiesDead())
            {
                au.PlaySound("MusicDay");
                au.StopSound("MusicNight");
                StartSunrise();
                currentNight += 1;
                timer = 15;
            }

        }
        timer -= 1 * Time.deltaTime;
        if (_light.intensity > 0.998f)
        {
            if (timer <= 0)
            {
                au.PlaySound("MusicNight");
                au.StopSound("MusicDay");
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
