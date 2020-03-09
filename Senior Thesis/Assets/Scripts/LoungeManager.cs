using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoungeManager : MonoBehaviour
{

    public static bool doneWithBlock;
    public static bool doneWithSlide;

    public void UpdateBlock(bool change)
    {
        doneWithBlock = change;
    }

    public void UpdateSlide(bool change)
    {
        doneWithSlide = change;
    }

    public bool GetBlock()
    {
        return doneWithBlock;
    }

    public bool GetSlide()
    {
        return doneWithSlide;
    }

    public void Update()
    {
        if (doneWithBlock == true && doneWithSlide == true)//and any more checks that are needed to be made, can add
        {
            //activate holograms
        }    
    }
    
}
