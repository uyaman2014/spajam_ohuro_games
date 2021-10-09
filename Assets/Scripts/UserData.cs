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
    public string UserName;
}
