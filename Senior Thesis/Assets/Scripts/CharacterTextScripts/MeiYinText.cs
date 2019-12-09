using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeiYinText : MonoBehaviour
{
    int counter = 0;
    bool isDone = false;
    public Text talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Oh, hi! I know you, you're that reporter, huh? I saw you poking around on the day of the accident. What a horrible day, don't you think?";
    public string npc2 = "Anyways, I'm Mei.  I'm glad someone is working hard to get us out of here.";
    public string npc3 = "Me? No, I don't know anything. Nothing that you don't already know, I'm sure. Maybe you should check in with the others.";
    public string npc4 = "Okay, bye now!\"";
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
        }
        else if (counter == 4)
        {
            temp = npc4;
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
