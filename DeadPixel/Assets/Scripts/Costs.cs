using UnityEngine;

[System.Serializable]
public class Costs{

    [SerializeField] private int mineral;
    [SerializeField] private int metal;
    [SerializeField] private int darkEnegry;


    public int Minerals{
        get{ return mineral; }
    }
    public int Metals{
        get{ return metal;}
    }
    public int DarkEnergy{
        get{ return darkEnegry; }
    }

}