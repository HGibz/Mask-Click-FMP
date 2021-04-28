using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public float savedMasks;
    public float savedUpgrade;
    public float savedValue;

    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedMasks = PlayerPrefs.GetFloat("SavedMasks");
            GlobalMasks.MaskCount = savedMasks;
            savedUpgrade = PlayerPrefs.GetFloat("SavedUpgrade");
            GlobalUpgrade.upgradPerSec = savedUpgrade;
            savedValue = PlayerPrefs.GetFloat("SavedValue");
            SaveGame.saveValue = savedValue;
        }
    }

    

    
}
