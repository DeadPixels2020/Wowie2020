using UnityEngine;

[System.Serializable]
public class Stats{

    [SerializeField] private int hp;
    [SerializeField] private int sheelds;

    public int HP{get => hp;}
    public int Sheelds{get => sheelds;}

}