using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using UnityEngine;

public class HttpRequestManager
{
    public PostJson PostJson = new PostJson();
    public ReplyJson ReplyJson = new ReplyJson();
    public bool IsPosting;
    private static HttpRequestManager _instance;
    public static HttpRequestManager Instance
    {
        get
        {
            if (_instance == null) _instance = new HttpRequestManager();
            return _instance;
        }
    }

    public async void PostDiary()
    {
        IsPosting = true;
        var content = new StringContent(JsonUtility.ToJson(PostJson), Encoding.UTF8, "application/json");
        using (var client = new HttpClient())
        {
            var response = await client.PostAsync("http://54.199.253.198:5000/post", content);
            var message = await response.Content.ReadAsStringAsync();
            Debug.Log(message);
            ReplyJson = JsonUtility.FromJson<ReplyJson>(message);
        }
        IsPosting = false;
    }

    public SummaryListJson SummaryListJson;
    public bool IsGetting;
    public async void GetSummary()
    {
        IsGetting = true;
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync("http://54.199.253.198:5000/summary");
            SummaryListJson = JsonUtility.FromJson<SummaryListJson>(await response.Content.ReadAsStringAsync());
        }
        IsGetting = false;
    }

}

[Serializable]
public class PostJson
{
    public string username;
    public string date;
    public string diary;
}

[Serializable]
public class ReplyJson
{
    public float score;
    public string reply;
}

[Serializable]
public class SummaryJson
{
    public string date;
    public float score;
}

[Serializable]
public class SummaryListJson
{
    public List<SummaryJson> data;
}
