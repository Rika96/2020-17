using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 

public class MainMenuControlScript : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i+1 > levelsUnlocked)
            levelButtons[i].interactable = false;
        }  
    }

    public void Select(string levelName)
    {
        fader.FadeTo(levelName);
    }

   
}

public class SceneFader
{
    internal void FadeTo(string levelName)
    {
        throw new NotImplementedException();
    }
}