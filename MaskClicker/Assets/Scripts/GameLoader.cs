using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedMasks;
    public int savedUpgrade;
    public int savedValue;

    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedMasks = PlayerPrefs.GetInt("SavedMasks");
            GlobalMasks.MaskCount = savedMasks;
            savedUpgrade = PlayerPrefs.GetInt("SavedUpgrade");
            GlobalUpgrade.upgradPerSec = savedUpgrade;
            savedValue = PlayerPrefs.GetInt("SavedValue");
            SaveGame.saveValue = savedValue;
        }
    }

    

    
}
