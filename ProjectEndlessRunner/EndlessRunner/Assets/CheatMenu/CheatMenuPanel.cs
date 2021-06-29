using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatMenuPanel : MonoBehaviour
{
    private PlayerData playerdata;
    private void Start() {
        playerdata = PlayerData.instance;
    }
    public void OnButtonAddCoins() {
        playerdata.coins += 100;
        playerdata.Save();
    } 

    public void OnButtonAddPremium() {
        playerdata.premium += 100;
        playerdata.Save();
    }

    public void OnButtonAddComsumables() {
        for (int i = 0; i < ShopItemList.s_ConsumablesTypes.Length; ++i) {
            var c = ConsumableDatabase.GetConsumbale(ShopItemList.s_ConsumablesTypes[i]);
            if (c != null) {
                playerdata.consumables[c.GetConsumableType()] += 10;
            }
        }

        playerdata.Save();
    }

    public void OnButtonClose() {
        gameObject.SetActive(false);
    }
}
