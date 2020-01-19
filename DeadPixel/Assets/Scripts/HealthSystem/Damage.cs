using UnityEngine;
public class Damage {
    

    private Stats stats;

    private GameObject dealer;

    public GameObject Dealer { get => dealer;}
    public Stats Stats { get => stats;}

    public int HP {get => stats.HP;}
    public int Sheelds{get => stats.Sheelds;} 


    public Damage(){
        stats = new Stats();
        dealer = null;
    }

    public Damage(int hp,int sheelds,GameObject dealer){
        stats = new Stats(hp,sheelds);
        this.dealer = dealer;
    }

    public Damage(int hp,int sheelds){
        stats = new Stats(hp,sheelds);
        this.dealer = null;
    }

}