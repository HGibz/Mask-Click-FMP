﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMask : MonoBehaviour
{

    public bool CreatingMask = false;
    public static float MaskIncrease = 1;
    public float InternalIncrease;
    

    
    void Update()
    {
        MaskIncrease = GlobalUpgrade.upgradPerSec;
        InternalIncrease = MaskIncrease;
        if (CreatingMask == false)
        {
            CreatingMask = true;
            StartCoroutine(CreateTheMask());
        }
    }

    IEnumerator CreateTheMask()
    {
        GlobalMasks.MaskCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingMask = false;
    }
}
