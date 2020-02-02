using UnityEngine;

[System.Serializable]
public class Stats{

    [SerializeField] private int hp;
    [SerializeField] private int sheelds;

    public int HP{get => hp;}
    public int Sheelds{get => sheelds;}

    public Stats(){
        hp = 0;
        sheelds = 0;
    }

    public Stats(int hp,int sheelds){
        this.hp = hp;
        this.sheelds = sheelds;
    }

}