using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = UserData.Instance.UserName + "さんの日記";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
