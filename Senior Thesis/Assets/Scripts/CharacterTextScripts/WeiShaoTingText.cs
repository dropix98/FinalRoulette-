using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeiShaoTingText : MonoBehaviour
{
    int counter = 0;
    bool isDone = false;
    public Text talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Hi, I’ve been waiting to meet you! I’m a bit of a detective myself. Sure, I’m just an intern in this building, but I am really on to something! I mean was, before I got fired.";
    public string npc2 = "Oh, sorry. My name’s ShaoTing, but that’s not important. I’m not a threat, I’m on your side!";
    public string npc3 = "Well, if I were you, I’d talk to Lin PinBi if you haven’t already. He was the lead detective on the case, but don’t let that fool you. I suspect he’s covering something up for YongRuan. If you don’t go interrogate him, I will!\"";
    public string temp = "";

    // Start is called before the first frame update
    void Start()
    {
        //talkText.text = npc1;
    }


    void Update()
    {
        if (isDone == false)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
            {
                counter++;
                DisplayText();
            }
        }
        else
        {
            talkText.text = "You've already talked with this person, look in your notebook to see the notes.";
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
            isDone = true;
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

    public bool IsDone()
    {
        
        return isDone;
    }
}
