using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData
{
    private static UserData _instance;
    public static UserData Instance
    {
        get
        {
            if (_instance == null) _instance = new UserData();
            return _instance;
        }
    }
    private string _userName;
    public string UserName
    {
        get => _userName; 
        set
        {
            _userName = value;
            HttpRequestManager.Instance.PostJson.username = value;
        }
    }
}
