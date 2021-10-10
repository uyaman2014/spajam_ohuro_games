using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpRequestManager
{
    public PostJson PostJson;
    private static HttpRequestManager _instance;
    public static HttpRequestManager Instance
    {
        get
        {
            if (Instance == null) _instance = new HttpRequestManager();
            return _instance;
        }
    }
}

[Serializable]
public class PostJson
{
    public string username;
    public string date;
    public string diary;
}