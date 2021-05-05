using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineUpgrade : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentMask;
    public static int upgradeValue = 1500;
    public static bool turnOffButton = false;
    public GameObject upgradeStats;
    public static int numberOfUpgrades;
    public static int upgradPerSec;




    void Update()
    {
        currentMask = GlobalMasks.MaskCount;
        upgradeStats.GetComponent<Text>().text = "Machines Level: " + numberOfUpgrades + " @ " + upgradPerSec + "Per Second";
        fakeText.GetComponent<Text>().text = "Upgrade Machines - M" + upgradeValue;
        realText.GetComponent<Text>().text = "Upgrade Machines - M" + upgradeValue;
        if (currentMask >= upgradeValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }

}
