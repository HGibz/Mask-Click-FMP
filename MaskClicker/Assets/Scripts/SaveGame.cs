using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameMask;
    public static int saveValue = 50;
    public GameObject saveButton;
    public GameObject saveText;

    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost : M" + saveValue;
        saveGameMask = GlobalMasks.MaskCount;
        if (saveGameMask >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {
        GlobalMasks.MaskCount -= saveValue;
        PlayerPrefs.SetInt("SavedMasks", GlobalMasks.MaskCount);
        PlayerPrefs.SetInt("SavedUpgrade", GlobalUpgrade.upgradPerSec);
        saveValue *= 2;
        PlayerPrefs.SetInt("SavedValue", saveValue);
    }
}
