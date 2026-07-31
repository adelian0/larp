using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{ 
    [SerializeField] TMP_Text countText;
    [SerializeField] TMP_Text incomeText;
    [SerializeField] [StoreUpgrade] storeUpgrade
     float count = 0;
        float nextTimeCheck = 1;
        float lastIncomeValue = 0;

    private void Start(){
        UpdateUi();
    }
    void Update(){
        if(nextTimeCheck < Time.timeSinceLevelLoad){
            IdleCalculate();
        nextTimeCheck = Time.timeSinceLevelLoad + 1f;
        }
    }
    void IdleCalculate() {
        float sum = 0;
        foreach (var storeUpgrades in storeUpgrades)
{
sum += storeUpgrades.CalculateIncomePerSecond();
}
lastIncomeValue = sum;
UpdateUi();
    }

    public void ClickAction(){
        count++;
        UpdateUi();
    }
public bool PurchaseAction(int cost){
if (count>=cost) {
    count -= cost;
    UpdateUi();
    return true;
}
return false;
    }// Update is called once per frame
    void Update(){
        countText.text = count.ToString();
        incomeText.text = lastIncomeValue.ToString() + "/s'";
    }
}
