﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ZhenYingHeiText : MonoBehaviour
{
    int counter = 0;
    public TextMeshPro talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Hello there. Can I help you?";
    public string npc2 = "Oh, yes. I have been expecting someone to come ask me questions. I am Zhen YingHei, JingHui’s lawyer. I still must uphold my client’s confidentiality, as you can understand. However, I am happy to provide you with any answers I can.";
    public string npc3 = "Yes, I’ve heard the rumor about me. It’s not true, I can tell you that. There’s no amount anyone could pay me to make sure JingHui died in that explosion. JingHui already pays me handsomely. I don’t need any more money. Not to mention, I’m not capable of murder.";
    public string npc4 = "If that’s all for now, I am going to go speak with my wife, XiaoJing, now.\"";
    public string temp = "";

    // Start is called before the first frame update
    void Start()
    {
        talkText.text = "Press <Space>";
        /*if (GlobalVariables.talkedZYH == true)
        {
          GlobalVariables.talkedZYH = false;
        }*/
    }


    void Update()
    {
        if (GlobalVariables.talkedZYH == false)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
            {
                counter++;
                if (counter > 3)
                {
                  SceneManager.LoadScene("MeetingRoom2");
                  GlobalVariables.talkedZYH = true;
                  GlobalVariables.numberOfPeopleTalkedTo++;
                }
                DisplayText();
            }
        }
        else
        {
            talkText.text = "You've already talked with this person, look in your notebook to see the notes.";
            if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
            {
              SceneManager.LoadScene("MaleBathroom2");
            }
        }
    }

    void DisplayText()
    {
        if (counter == 1)
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
        }
        else if (counter == 4)
        {
            temp = npc3;
            UpdateText();
            UpdateInvClues();
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

    /*public bool IsDone()
    {

        return isDone;
    }*/
}
