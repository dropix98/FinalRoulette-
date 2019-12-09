using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WangYiZhengText : MonoBehaviour
{
    int counter = 0;
    public TextMeshPro talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Hey, reporter girl. I was wondering when you’d come talk to me! This whole situation is fucking shitty. Leave it to JingHui to pull a stunt like this.";
    public string npc2 = "Well, of course it’s him who put us in here! It  makes the most sense, doesn’t it? He wants to find out who nuked his building. Well, I bet he did it himself, honestly. He’s always been in it for the publicity. This is just another stunt, and now he’s trying to pin it on someone else.";
    public string npc3 = "Yeah, I’m technically his brother, but he’s the worst fucking brother I ever had! Always trying to be the star of everything! Damn, I’m getting worked up about this. Give me a sec to cool down.\"";
    public string temp = "";

    // Start is called before the first frame update
    void Start()
    {
        talkText.text = "Press <Space>";
        /*if (GlobalVariables.talkedWY == true)
        {
          GlobalVariables.talkedWY = false;
        }*/
    }


    void Update()
    {
        if (GlobalVariables.talkedWY == false)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
            {
                counter++;
                if (counter > 3)
                {
                  SceneManager.LoadScene("Floor2Final");
                  GlobalVariables.talkedWY = true;
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
              SceneManager.LoadScene("Floor2Final");
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
