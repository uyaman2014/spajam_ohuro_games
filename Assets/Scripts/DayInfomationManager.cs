using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayInfomationManager
{
    private static DayInfomationManager _instance;
    private DateTime _dateTime;
    public DateTime DateTime { get => _dateTime; set { _dateTime = value; HttpRequestManager.Instance.PostJson.date = _dateTime.ToString("d"); } }
    public static DayInfomationManager Instance
    {
        get
        {
            if (_instance == null) _instance = new DayInfomationManager();
            return _instance;
        }
    }
}
