using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DairyInput : MonoBehaviour
{
    public void ConfirmInput()
    {
        HttpRequestManager.Instance.PostJson.diary = GetComponent<InputField>().text;
    }
}
