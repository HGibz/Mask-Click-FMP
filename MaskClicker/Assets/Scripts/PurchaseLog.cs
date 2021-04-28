using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoMask;

    public void StartAutoMask()
    {
        AutoMask.SetActive(true);
        GlobalMasks.MaskCount -= GlobalUpgrade.upgradeValue;
        GlobalUpgrade.upgradeValue *= 2;
        GlobalUpgrade.turnOffButton = true;
        GlobalUpgrade.upgradPerSec += 1;
        GlobalUpgrade.numberOfUpgrades += 1;
    }
    public void StartFactory()
    {
        AutoMask.SetActive(true);
        GlobalMasks.MaskCount -= FactoryUpgrade.upgradeValue;
        FactoryUpgrade.upgradeValue *= 1.5f;
        FactoryUpgrade.turnOffButton = true;
        FactoryUpgrade.upgradPerSec += 5;
        FactoryUpgrade.numberOfUpgrades += 1;
    }

}
