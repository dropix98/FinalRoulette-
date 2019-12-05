using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZhuangYongRuanText : MonoBehaviour
{
    int counter = 0;
    bool isDone = false;
    public Text talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Ugh, you, too? I don’t need more people suspecting me. I know ShaoTing has it out for me. She’s wrong, though. I might’ve been rivals with JingHui, but that’s it. I wouldn’t blow up his building. I’m not that petty.";
    public string npc2 = "Well, JingHui and I knew each other since college. He’s always been good at everything and never put much work into it. I’ve had to bust my ass to get where I am. And still, where does that leave me? A murder suspect! Jesus!";
    public string npc3 = "No, I don’t want to talk anymore.\"";
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
