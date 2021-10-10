using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ImageNames
{
    Angry, Happy, Sad, Thinking, UkiUki
}

public class CharacterLoader : MonoBehaviour
{
    [SerializeField]
    private List<Image> _characterAngryList;
    [SerializeField]
    private List<Image> _characterHappyList;
    [SerializeField]
    private List<Image> _characterSadList;
    [SerializeField]
    private List<Image> _characterThinkingList;
    [SerializeField]
    private List<Image> _characterUkiUkiList;

    private int _index = 0;

    private Dictionary<ImageNames, Image> _characterImages;
    // Start is called before the first frame update
    void Start()
    {
        SetCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetCharacter()
    {
        _characterImages[ImageNames.Angry] = _characterAngryList[_index];
        _characterImages[ImageNames.Happy] = _characterHappyList[_index];
        _characterImages[ImageNames.Sad] = _characterSadList[_index];
        _characterImages[ImageNames.Thinking] = _characterThinkingList[_index];
        _characterImages[ImageNames.UkiUki] = _characterUkiUkiList[_index];
    }

    public void ChangeCharacterLeft()
    {
        _index++;
        if (_index > _characterAngryList.Count) _index = 0;
    }

    public void ChangeCharacterRight()
    {
        _index--;
        if (_index < 0) _index = _characterAngryList.Count - 1;
    }
}
