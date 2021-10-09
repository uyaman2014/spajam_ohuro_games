using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DayInfomation : MonoBehaviour
{
    private DateTime _dateTime;
    public DateTime DateTime { get { return _dateTime; } set { _dateTime = value; UpdateText(); } }
    [SerializeField]
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        _text.text = DateTime.Year.ToString() + "\n" + DateTime.Month.ToString() + "/" + DateTime.Day.ToString();
    }
}
