﻿using System.Collections;
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
        FactoryUpgrade.upgradeValue *= 2;
        FactoryUpgrade.turnOffButton = true;
        FactoryUpgrade.upgradPerSec += 5;
        FactoryUpgrade.numberOfUpgrades += 1;
    }


    public void StartManager()
    {
        AutoMask.SetActive(true);
        GlobalMasks.MaskCount -= ManagerUpgrade.upgradeValue;
        ManagerUpgrade.upgradeValue *= 2;
        ManagerUpgrade.turnOffButton = true;
        ManagerUpgrade.upgradPerSec += 15;
        ManagerUpgrade.numberOfUpgrades += 1;
    }

    public void StartWorker()
    {
        AutoMask.SetActive(true);
        GlobalMasks.MaskCount -= WorkerUpgrade.upgradeValue;
        WorkerUpgrade.upgradeValue *= 2;
        WorkerUpgrade.turnOffButton = true;
        WorkerUpgrade.upgradPerSec += 40;
        WorkerUpgrade.numberOfUpgrades += 1;
    }

    public void StartMachine()
    {
        AutoMask.SetActive(true);
        GlobalMasks.MaskCount -= MachineUpgrade.upgradeValue;
        MachineUpgrade.upgradeValue *= 2;
        MachineUpgrade.turnOffButton = true;
        MachineUpgrade.upgradPerSec += 100;
        MachineUpgrade.numberOfUpgrades += 1;
    }


}
