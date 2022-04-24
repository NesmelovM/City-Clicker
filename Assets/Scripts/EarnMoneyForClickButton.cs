using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EarnMoneyForClickButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Button _button;

    
    public void OnPointerClick(PointerEventData eventData)
    {
        _gameManager.AddMoney();
    }
}
