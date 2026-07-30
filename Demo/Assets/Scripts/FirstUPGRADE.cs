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
    public float upgradePriceMultiplier = 1.15f;
    public float browniesPerUpgrade = 0.1f;

    int level = 0;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        if (priceText != null)
            priceText.text = CalculatePrice().ToString();

        if (incomeInfoText != null)
            incomeInfoText.text = level.ToString() + "x" + browniesPerUpgrade + "/s";
    }

    int CalculatePrice()
    {
        int price = Mathf.RoundToInt(startPrice * Mathf.Pow(upgradePriceMultiplier, level));
        return price;
    }

    public float CalculateIncomePerSecond()
    {
        return level * browniesPerUpgrade;
    }
}
