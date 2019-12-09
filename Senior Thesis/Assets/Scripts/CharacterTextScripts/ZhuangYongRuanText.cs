using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ZhuangYongRuanText : MonoBehaviour
{
    int counter = 0;
    public TextMeshPro talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Ugh, you, too? I don’t need more people suspecting me. I know ShaoTing has it out for me. She’s wrong, though. I might’ve been rivals with JingHui, but that’s it. I wouldn’t blow up his building. I’m not that petty.";
    public string npc2 = "Well, JingHui and I knew each other since college. He’s always been good at everything and never put much work into it. I’ve had to bust my ass to get where I am. And still, where does that leave me? A murder suspect! Jesus!";
    public string npc3 = "No, I don’t want to talk anymore.\"";
    public string temp = "";

    // Start is called before the first frame update
    void Start()
    {
        talkText.text = "Press <Space>";
        /*if (GlobalVariables.talkedZYR == true)
        {
          GlobalVariables.talkedZYR = false;
        }*/
    }


    void Update()
    {
        if (GlobalVariables.talkedZYR == false)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
            {
                counter++;
                if (counter > 3)
                {
                  SceneManager.LoadScene("MeetingRoom1");
                  GlobalVariables.talkedZYR = true;
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
              SceneManager.LoadScene("MeetingRoom1");
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
