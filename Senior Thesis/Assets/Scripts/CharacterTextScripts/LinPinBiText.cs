using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LinPinBiText : MonoBehaviour
{
    int counter = 0;
    public TextMeshPro talkText;
    //change and add the nuymber pf unique text amounts.
    public string npc1 = "\"Ah, the reporter. I’m Detective PinBi. What do you think is going on here?";
    public string npc2 = "Hah. Makes sense you don’t know yet. I don’t know why a novice journalist is on such a high profile case.";
    public string npc3 = "Fine, so you’re not a novice. What does it matter? Anyone with eyes can see that ShaoTing, YiZheng, and Mei Yin are top suspects. We should only interrogate them. They all have their own motives.";
    public string npc4 = "Psh, ask them yourself if you’re such a good journalist!\"";
    public string temp = "";

    // Start is called before the first frame update
    void Start()
    {
        talkText.text = "Press <Space>";
        /*if (GlobalVariables.talkedLP == true)
        {
          GlobalVariables.talkedLP = false;
        }*/
    }


    void Update()
    {
        if (GlobalVariables.talkedLP == false)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
            {
                counter++;
                if (counter > 3)
                {
                  SceneManager.LoadScene("Floor2Final");
                  GlobalVariables.talkedLP = true;
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
