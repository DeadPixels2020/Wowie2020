using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPocket : MonoBehaviour,IPaymentController,IEarningsController
{

    public static PlayerPocket Pocket;

    private int matirial;

    public int Matirial{get;}

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
        return matirial >= costs.Matirial;
    }

    public void Pay(Costs costs)
    {
        matirial -= costs.Matirial;
        OnMatirialAmountChenged(matirial);
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
        matirial += earning.Matirial;
        OnMatirialAmountChenged(matirial);
    }

    public event Action<int> OnMatirialAmountChenged;
}
