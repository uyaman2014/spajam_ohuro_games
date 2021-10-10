using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DairyInput : MonoBehaviour
{
    public void Start()
    {
        if(DairyList.Instance._dairyList.ContainsKey(DayInfomationManager.Instance.DateTime.ToLongDateString()))
            GetComponent<InputField>().text = DairyList.Instance._dairyList[DayInfomationManager.Instance.DateTime.ToLongDateString()];
    }

    public void ConfirmInput()
    {
        HttpRequestManager.Instance.PostJson.diary = GetComponent<InputField>().text;
        DairyList.Instance._dairyList.Add(DayInfomationManager.Instance.DateTime.ToLongDateString(), GetComponent<InputField>().text);
    }
}
