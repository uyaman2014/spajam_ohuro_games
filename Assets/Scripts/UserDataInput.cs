using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserDataInput : MonoBehaviour
{
    public void SetName()
    {
        UserData.Instance.UserName = GetComponent<InputField>().text;
    }
}
