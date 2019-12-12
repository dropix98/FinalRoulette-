﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EmailText : MonoBehaviour
{
  int counter = 0;
  public TextMeshPro talkText;
  //change and add the nuymber pf unique text amounts.
  public string npc1 = "“Maybe I should try this keycard on the exit.";
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
      if (GlobalVariables.foundEmail == false)
      {
          if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
          {
              counter++;
              if (counter > 1)
              {
                SceneManager.LoadScene("Floor1Final");
                GlobalVariables.foundEmail = true;
              }
              DisplayText();
          }
      }
      else
      {
          talkText.text = "You've already read the email, try looking in your notebook to see the notes.";
          if (Input.GetKeyDown(KeyCode.Space)) //&& if global varibale to meet is true to allow the texts to work.
          {
            SceneManager.LoadScene("Floor1Final");
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