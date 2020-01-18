﻿using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
[RequireComponent(typeof(Light2D))]
public class DayNightCycle : MonoBehaviour
{
    private Light2D _light;
    [SerializeField] private float chengScale;
    [SerializeField] private bool invert;

    private bool isDay;
    private float chengIntensityTo;

    private IDayNightSeter dayNightSeter;

    private void Awake()
    {
        _light = GetComponent<Light2D>();
        chengIntensityTo = 0;
        isDay = true;
        dayNightSeter = GameEvents.instance;
    }

    private void Update()
    {
        _light.intensity = Mathf.Lerp(_light.intensity, chengIntensityTo, Time.deltaTime * chengScale);

        if (_light.intensity < 0.01f && isDay)
        {
            isDay = false;
            chengIntensityTo = 1;
            dayNightSeter.onGettingDark();
        }
        if (_light.intensity > 0.98f && !isDay)
        {
            isDay = true;
            chengIntensityTo = 0;
            dayNightSeter.onGettingBrighter();
        }
    }



}

