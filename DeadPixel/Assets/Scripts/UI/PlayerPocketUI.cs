using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPocketUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coins;

    private void Start() {
        PlayerPocket.Pocket.OnMatirialAmountChenged += UpdateCoins;
        UpdateCoins(PlayerPocket.Pocket.Matirial);
    }

    private void UpdateCoins(int val){
        coins.text = val + "";
    }

    private void OnDestroy() {
        PlayerPocket.Pocket.OnMatirialAmountChenged += UpdateCoins;
    }
}
