using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CalenderSelector : MonoBehaviour
{
    [SerializeField]
    private GameObject _leftButton;
    [SerializeField]
    private GameObject _rightButton;
    [SerializeField]
    private GameObject _centerButton;
    private bool _isMoveing;
    private float _moveCount = 600;
    [SerializeField]
    private float _moveSpeed = 60f;

    private void Start()
    {
        SelectToday();
    }

    public void SelectLeft()
    {
        if (!_isMoveing) StartCoroutine(MoveLeft());
        _isMoveing = true;
    }

    public void SelectRight()
    {
        if (!_isMoveing) StartCoroutine(MoveRight());
        _isMoveing = true;
    }

    public void SelectToday()
    {
        _leftButton.GetComponent<DayInfomation>().DateTime = DateTime.Today.AddDays(-1);
        _centerButton.GetComponent<DayInfomation>().DateTime = DateTime.Today;
        _rightButton.GetComponent<DayInfomation>().DateTime = DateTime.Today.AddDays(1);
    }

    private IEnumerator MoveLeft()
    {
        for (int i = 0; i < _moveCount / _moveSpeed; i++)
        {
            yield return null;
            _leftButton.GetComponent<RectTransform>().anchoredPosition -= Vector2.right * _moveSpeed;
            _rightButton.GetComponent<RectTransform>().anchoredPosition -= Vector2.right * _moveSpeed;
            _centerButton.GetComponent<RectTransform>().anchoredPosition -= Vector2.right * _moveSpeed;
            if (_leftButton.GetComponent<RectTransform>().anchoredPosition.x < -700)
            {
                _leftButton.GetComponent<RectTransform>().anchoredPosition = _rightButton.GetComponent<RectTransform>().anchoredPosition + new Vector2(600, 0);
                var _rightDay = _rightButton.GetComponent<DayInfomation>().DateTime;
                _leftButton.GetComponent<DayInfomation>().DateTime = _rightDay.AddDays(1);
                var tmp = _leftButton;
                _leftButton = _centerButton;
                _centerButton = _rightButton;
                _rightButton = tmp;
            }
        }
        _isMoveing = false;
    }

    private IEnumerator MoveRight()
    {
        for (int i = 0; i < _moveCount / _moveSpeed; i++)
        {
            yield return null;
            _leftButton.GetComponent<RectTransform>().anchoredPosition += Vector2.right * _moveSpeed;
            _rightButton.GetComponent<RectTransform>().anchoredPosition += Vector2.right * _moveSpeed;
            _centerButton.GetComponent<RectTransform>().anchoredPosition += Vector2.right * _moveSpeed;
            if (_rightButton.GetComponent<RectTransform>().anchoredPosition.x > 700)
            {
                _rightButton.GetComponent<RectTransform>().anchoredPosition = _leftButton.GetComponent<RectTransform>().anchoredPosition - new Vector2(600, 0);
                var leftDay = _leftButton.GetComponent<DayInfomation>().DateTime;
                _rightButton.GetComponent<DayInfomation>().DateTime = leftDay.AddDays(-1);
                var tmp = _rightButton;
                _rightButton = _centerButton;
                _centerButton = _leftButton;
                _leftButton = tmp;
            }
        }
        _isMoveing = false;
    }
}
