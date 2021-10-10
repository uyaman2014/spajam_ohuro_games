using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpRequest : MonoBehaviour
{
    public void SendRequest()
    {
        HttpRequestManager.Instance.PostDiary();
    }
}
