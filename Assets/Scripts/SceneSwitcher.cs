using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scenes
{
    Title, Login, Calendar, EmotionGraph, Dialy, CharacterMessage, OldMessages, CharacterSelect
}

public class SceneSwitcher : MonoBehaviour
{
    public void ToTitle()
    {
        SceneManager.LoadSceneAsync(Scenes.Title.ToString());
    }
    public void ToLogin()
    {
        SceneManager.LoadSceneAsync(Scenes.Login.ToString());
    }
    public void ToCalender()
    {
        SceneManager.LoadSceneAsync(Scenes.Calendar.ToString());
    }
    public void ToGraph()
    {
        SceneManager.LoadSceneAsync(Scenes.EmotionGraph.ToString());
    }
    public void ToDialy()
    {
        SceneManager.LoadSceneAsync(Scenes.Dialy.ToString());
    }
    public void ToCharacterMessage()
    {
        SceneManager.LoadSceneAsync(Scenes.CharacterMessage.ToString());
    }
    public void ToOldMessages()
    {
        SceneManager.LoadSceneAsync(Scenes.OldMessages.ToString());
    }
    public void ToCharacterSelect()
    {
        SceneManager.LoadSceneAsync(Scenes.CharacterSelect.ToString());
    }
}
