using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFactory : MonoBehaviour
{
    public bool CreatingMask = false;
    public static int MaskIncrease = 5;
    public int InternalIncrease;



    void Update()
    {
        MaskIncrease = FactoryUpgrade.upgradPerSec;
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
