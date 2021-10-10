using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayInformationViewer : MonoBehaviour
{
    [SerializeField]
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = DayInfomationManager.Instance.DateTime.ToString("M/d(ddd)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
