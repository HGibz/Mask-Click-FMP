using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalMasks : MonoBehaviour
{
    public static int MaskCount;
    public GameObject MaskDisplay;
    public int InternalMask;

    void Update()
    {
        InternalMask = MaskCount;
        MaskDisplay.GetComponent<Text>().text = "Masks: " + InternalMask;
    }
}
