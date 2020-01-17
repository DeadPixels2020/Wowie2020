using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.LWRP;
[RequireComponent(typeof(Light2D))]
public class DayNightCycle : MonoBehaviour
{
    //nikinov
    public Image BringUpWeapons;
    public Image SettingsButton;

    //others
    private Light2D _light;
    [SerializeField] private float chengScale;
    [SerializeField] private bool invert;

    private bool isDay;
    private float chengIntensityTo;

    private void Awake()
    {
        _light = GetComponent<Light2D>();
        chengIntensityTo = 0;
        isDay = true;
    }

    private void Update()
    {
        _light.intensity = Mathf.Lerp(_light.intensity,chengIntensityTo,Time.deltaTime * chengScale);

        if(_light.intensity < 0.01f && isDay)
        {
            isDay = false;
            chengIntensityTo = 1;
        }
        if(_light.intensity > 0.98f && !isDay)
        {
            isDay = true;
            chengIntensityTo = 0;
        }
        //more nikinov
        SettingsButton.color.a.Equals(_light.intensity * 255);
    }

}
