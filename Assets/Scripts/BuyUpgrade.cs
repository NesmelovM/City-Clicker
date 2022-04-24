using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUpgrade : MonoBehaviour
{
    [SerializeField] int _cost, _addedCount, _value;
    [SerializeField] string description;
    [SerializeField] Button _button;
    [SerializeField] Text  _description, _addedCountText;
    [SerializeField] GameManager _gameManager;

    public void Start()
    {
        _button.onClick.AddListener(Buy);
        _description.text = description;
        _addedCountText.text = _addedCount.ToString();
    }

    public void Buy()
    {

        _gameManager.TryToBuy(_cost, _value);
        
    }
}
