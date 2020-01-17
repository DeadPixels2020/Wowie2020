using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPocket : MonoBehaviour,IPaymentController,IEarningsController
{

    public static PlayerPocket Pocket;

    private int mineral;
    private int metal;
    private int darkEnegry;

    private void Awake() {
        if(Pocket == null){
            Pocket = this;
        }else{
            Destroy(gameObject);
            return;
        }
    }

    public bool AbleToPay(Costs costs)
    {
        return mineral >= costs.Minerals && metal >= costs.Metals && darkEnegry >= costs.DarkEnergy;
    }

    public void Pay(Costs costs)
    {
        mineral -= costs.Minerals;
        metal -= costs.Metals;
        darkEnegry -= costs.DarkEnergy;
    }

    public bool TryToPay(Costs costs)
    {
        if(AbleToPay(costs)){
            Pay(costs);
            return true;
        }

        return false;
    }

    public void AddToPocket(Costs earning)
    {
        mineral += earning.Minerals;
        metal += earning.Metals;
        darkEnegry += earning.DarkEnergy;
    }
}
