using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DairyList
{
    private static DairyList _instance;

    public static DairyList Instance
    {
        get
        {
            if (_instance == null) _instance = new DairyList();
            return _instance;
        }
    }

    public Dictionary<DateTime, string> _dairyList = new Dictionary<DateTime, string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
