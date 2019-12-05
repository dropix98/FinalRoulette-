using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{

    public class NotebookHintsText : MonoBehaviour
    {

        private TextMeshPro textPrint;
        private TextMeshPro textKeycard;
        private TextMeshPro textNewsArticle;
        private TextMeshPro textEmail;
        private TextMeshPro textJanitor;
        private TextMeshPro textSecretary;



        void Start()
        {
            textPrint = GetComponent<TextMeshPro>();

            GlobalVariables.triedKeycardOnDoor = true;
            GlobalVariables.foundNewsArticle = true;
            GlobalVariables.foundEmail = true;
            GlobalVariables.foundJanitorHint = true;
            GlobalVariables.foundSecretaryHint = true;
        }


        void Update()
        {
            textPrint.text = "";

            if (GlobalVariables.triedKeycardOnDoor == true)
            {
              textPrint.text += ">The first letter of the passcode is O.";
            }
            if (GlobalVariables.foundNewsArticle == true)
            {
              if (textPrint.text == "")
              {
                textPrint.text += ">On the News Article I found, the letter S was circled in red.";
              }
              else
              {
                textPrint.text += "\n" + ">On the News Article I found, the letter S was circled in red.";
              }
            }
            if (GlobalVariables.foundEmail == true)
            {
              if (textPrint.text == "")
              {
                textPrint.text += ">The email said A is the last letter of the passcode." + "\n" +
                                 ">The email said the middle three letters are in alphabetical order.";
              }
              else
              {
                textPrint.text += "\n" + ">The email said A is the last letter of the passcode." + "\n" +
                                 ">The email said the middle three letters are in alphabetical order.";
              }
            }
            if (GlobalVariables.foundJanitorHint == true)
            {
              if (textPrint.text == "")
              {
                textPrint.text += ">The Janitor is kind of odd. He won’t talk to me. He just keeps repeating the letter Z.";
              }
              else
              {
                textPrint.text += "\n" + ">The Janitor is kind of odd. He won’t talk to me. He just keeps repeating the letter Z.";
              }
            }
            if (GlobalVariables.foundSecretaryHint == true)
            {
              if (textPrint.text == "")
              {
                textPrint.text += ">JingHui’s secretary, XiaoJing, isn’t very talkative. She did tell me there is a J in the passcode, though.";
              }
              else
              {
                textPrint.text += "\n" + ">JingHui’s secretary, XiaoJing, isn’t very talkative. She did tell me there is a J in the passcode, though.";
              }
            }

            if (textPrint.text == "")
            {
              textPrint.text += "No Keycode Clues Found Yet...";
            }

        }

    }
}
