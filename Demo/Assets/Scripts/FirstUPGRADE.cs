using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstUPGRADE : MonoBehaviour
{
    [Header("Components")]
    public TMP_Text priceText; 
    public TMP_Text incomeInfoText; 

    public int startPrice = 15;
    public float upgradePriceMultiplier;
    public float browniesPerUpgrade = 0.1f ;
 

    int level = 0;
void UpdateUi(){
    priceText.text = CalculatePrice().ToString();
   incomeInfoText.text = level.ToString() + "x" + browniesPerUpgrade + "/s";
   // 5 x 0.5/s
}
int CalculatePrice(){
        int Price = Mathf.RoundToInt(startPrice * Mathf.Pow(upgradePriceMultiplier,level));
        return Price;
    }
    float CalculateIncomePerSecond(){
        return browniesPerUpgrade * level; 
     }}
