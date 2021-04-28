using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public float saveGameMask;
    public static float saveValue = 50;
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
        PlayerPrefs.SetFloat("SavedMasks", GlobalMasks.MaskCount);
        PlayerPrefs.SetFloat("SavedUpgrade", GlobalUpgrade.upgradPerSec);
        saveValue *= 2;
        PlayerPrefs.SetFloat("SavedValue", saveValue);
    }
}
