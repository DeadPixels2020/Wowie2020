using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour,IDayNightSeter
{

    public static GameEvents instance;

    private void Awake() {
        
        if(instance == null){
            instance = this;
        }else if(instance != this){
            Destroy(this);
        }
    }

    public event Action OnDayStarts;
    public event Action OnNightStarts;

    public void onGettingDark(){
        if(OnNightStarts == null)
            return;

        OnNightStarts();
    }

    public void onGettingBrighter(){
        if(OnDayStarts == null)
            return;

        OnDayStarts();
    }

}
