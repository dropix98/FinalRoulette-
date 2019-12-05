using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChengSuRongText : MonoBehaviour
{
    int counter = 0;
    bool isDone = false;
    public Text talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"What? Oh. Sorry, but you shouldn't sneak up on people like that. Especially not in this situation. I can't trust anyone anymore. Wait, who are you again?";
    public string npc2 = "Right. I'm SuRong. Do you know why we're here? I can't help but think this has everything to do with the accident";
    public string npc3 = "Well, if you're asking me, I think anyone here could've caused the accident. I bet you can figure it out, though. Let me know if you need any help, okay?\"";
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
