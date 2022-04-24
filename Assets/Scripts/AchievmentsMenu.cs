using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AchievmentsMenu : MonoBehaviour
{

    [SerializeField] public int TotalMoney;


    [SerializeField] Button FirstAch;
    [SerializeField] bool isfirst = true;
    

    private void Start()
    {
        TotalMoney = PlayerPrefs.GetInt("TotalMoney");
        isfirst = PlayerPrefs.GetInt("isfirst") == 1 ?   true : false;

        if (TotalMoney >= 100 && isfirst)
        {
            FirstAch.interactable = true;
        }
        else
        {
            FirstAch.interactable = false;
        }
    }
    public void GetFirst()
    {
        int _money = PlayerPrefs.GetInt("Money");
        _money += 10;
        PlayerPrefs.SetInt("Money", _money);
        PlayerPrefs.GetInt("Money");
        isfirst = false;
        PlayerPrefs.SetInt("isfirst", isfirst ? 1 : 0);
    }

    private void Update()
    {
        
    }

}
