using UnityEngine;

public class HealAmount
{
    private Stats stats;

    private GameObject dealer;

    public GameObject Dealer { get => dealer;}
    public Stats Stats { get => stats;}

    public int HP {get => stats.HP;}
    public int Sheelds{get => stats.Sheelds;} 


    public HealAmount(){
        stats = new Stats();
        dealer = null;
    }

    public HealAmount(int hp,int sheelds,GameObject dealer){
        stats = new Stats(hp,sheelds);
        this.dealer = dealer;
    }

    public HealAmount(int hp,int sheelds){
        stats = new Stats(hp,sheelds);
        this.dealer = null;
    }
}
