using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPocket : MonoBehaviour,IPaymentController,IEarningsController
{
    public UIManager UIm;

    public static PlayerPocket Pocket;

    private int matirial = 40;

    public int Matirial{get => matirial;}

    int check;
    int check2 = 0;

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
        checkingstuff();
        matirial -= costs.Matirial;
        if(OnMatirialAmountChenged != null)    
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
        checkingstuff();
        matirial += earning.Matirial;
        if(OnMatirialAmountChenged != null)    
            OnMatirialAmountChenged(matirial);
    }

    void checkingstuff()
    {
        check = 0;
        foreach (int i in UIm.Prices)
        {
            if (Pocket.matirial <= i)
            {
                check += 1;
            }
        }
        if (check != check2)
        {
            check = check2;
            UIm.AdjustWeapuns(matirial);
        }
    }
    public event Action<int> OnMatirialAmountChenged;
}
