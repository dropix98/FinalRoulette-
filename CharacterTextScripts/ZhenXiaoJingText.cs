﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZhenXiaoJingText : MonoBehaviour
{
    int counter = 0;
    bool isDone = false;
    public Text talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Ah, so you’re the journalist. Yeah, I worked for JingHui. I was his secretary. My name’s Zhen XiaoJing.";
    public string npc2 = "I don’t really want to talk about the accident. I think it was a horrible, no doubt about it. Is there anything else I can help you with?";
    public string npc3 = "Sorry. I don’t remember the door passcode anymore, or else we’d already be out of this room. I think there’s a J in there somewhere, but that’s all I can remember. If that’s all, I’d like to be alone right now.\"";
    public string temp = "";

    // Start is called before the first frame update
    void Start()
    {
        //talkText.text = npc1;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
        {
            counter++;
            DisplayText();
        }
    }

    void DisplayText()
    {
        if(counter == 1)
        {
            temp = npc1;
            UpdateText();
        }
        else if (counter == 2)
        {
            temp = npc2;
            UpdateText();
        }
        else if (counter == 3)
        {
            temp = npc3;
            UpdateText();
            UpdateInvClues();
            IsDone();
        }
        else
        {
            talkText.text = "";
        }
    }

    void UpdateText()
    {
        talkText.text = temp;
    }

    void UpdateInvClues()
    {

    }

    bool IsDone()
    {
        isDone = true;
        return isDone;
    }
}
