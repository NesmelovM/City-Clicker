using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    [SerializeField] private GameObject _window;
    [SerializeField] private Button _button;

    public void Start()
    {
        _button.onClick.AddListener(ToggleOppen);
    }
    public void Open()
    {
        _window.SetActive(true);
    }

    public void Close()
    {
        _window?.SetActive(false);
    }

    public void ToggleOppen()
    {
        if (_window.activeSelf)
            Close();
        else
            Open();

    }
}
