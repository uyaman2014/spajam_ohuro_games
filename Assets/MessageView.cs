using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class MessageView : MonoBehaviour
{
    [SerializeField]
    private Image _huwahuwa;
    [SerializeField]
    private Image _hukidasi;
    [SerializeField]
    private Text _message;
    [SerializeField]
    private Image _sad;
    [SerializeField]
    private Image _happy;
    [SerializeField]
    private Image _think;
    // Start is called before the first frame update
    void Start()
    {
        _huwahuwa.enabled = true;
        _hukidasi.enabled = false;
        _message.enabled = false;
        ShowMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void ShowMessage()
    {
        while (HttpRequestManager.Instance.IsPosting)
        { 
            await Task.Delay(10);
        }
        _huwahuwa.enabled = false;
        _hukidasi.enabled = true;
        _message.enabled = true;
        _message.text = HttpRequestManager.Instance.ReplyJson.reply;
        _think.enabled = false;
        if(HttpRequestManager.Instance.ReplyJson.score > 0)
        {
            _sad.enabled = false;
            _happy.enabled = true;
        }
        else
        {
            _sad.enabled = true;
            _happy.enabled = false;
        }
    }
}
