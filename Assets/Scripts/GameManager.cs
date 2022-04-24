using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
        public int Money;
        public int TotalMoney;
        public int MoneyPerClick;
        private int _addedPerclickUpgrade;
              
        public Text MoneyText,_addedPerclickUpgradeTXT;

    // Start is called before the first frame update
    void Start()
    {
        AddPerClickValue();        
        Money = PlayerPrefs.GetInt("Money");
        TotalMoney = PlayerPrefs.GetInt("TotalMoney");
        MoneyPerClick = PlayerPrefs.GetInt("MoneyPerClick") - 1;
        _addedPerclickUpgrade = PlayerPrefs.GetInt("MoneyPerClick") - 1;
    }
    public void AddMoney()
    {
        Money += MoneyPerClick;
        PlayerPrefs.SetInt("Money", Money);

        TotalMoney += MoneyPerClick;
        PlayerPrefs.SetInt("TotalMoney", TotalMoney);
    }

    public void SpendMoney(int cost)
    {
        Money -= cost;
        PlayerPrefs.SetInt("Money", Money);
    }
    public void AddPerClickValue()
    {
        MoneyPerClick++;
        PlayerPrefs.SetInt("MoneyPerClick", MoneyPerClick);
    }

    public void TryToBuy(int cost, int addPerclick)
    {
        if (Money >+ cost)
        {
            SpendMoney(cost);
            MoneyPerClick += addPerclick;
            _addedPerclickUpgrade++;
            _addedPerclickUpgradeTXT.text = (_addedPerclickUpgrade -1).ToString();
            
        }
                
    }



    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Money.ToString();  
    }
  
}
