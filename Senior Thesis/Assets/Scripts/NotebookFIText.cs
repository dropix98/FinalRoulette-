using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TMPro.Examples
{

    public class NotebookFIText : MonoBehaviour
    {

        private TextMeshPro textPrint2;
        private TextMeshPro talkedMY;
        private TextMeshPro talkedCS;
        private TextMeshPro talkedWY;
        private TextMeshPro talkedZX;
        private TextMeshPro talkedZYH;
        private TextMeshPro talkedWS;
        private TextMeshPro talkedLP;
        private TextMeshPro talkedLM;


        void Start()
        {
            textPrint2 = GetComponent<TextMeshPro>();

            //set to false for final build
            GlobalVariables.talkedMY = true;
            GlobalVariables.talkedCS = true;
            GlobalVariables.talkedWY = true;
            GlobalVariables.talkedZX = true;
            GlobalVariables.talkedZYH = true;
            GlobalVariables.talkedWS = true;
            GlobalVariables.talkedZYR = true;
            GlobalVariables.talkedLP = true;
            GlobalVariables.talkedLM = true;
        }


        void Update()
        {
            textPrint2.text = "";

            if (GlobalVariables.talkedMY == true)
            {
              textPrint2.text += ">Mei seems friendly enough. Very bubbly. But she’s definitely hiding something. She used to date JingHui, after all.";
            }
            if (GlobalVariables.talkedCS == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">SuRong is a bit awkward, but seems happy to help.";
              }
              else
              {
                textPrint2.text += "\n" + ">SuRong is a bit awkward, but seems happy to help.";
              }
            }
            if (GlobalVariables.talkedWY == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">YiZheng apparently hates his brother. He’s already trying to pin the accident on JingHui. Could his hatred be a possible motive? Or is he right about JingHui?";
              }
              else
              {
                textPrint2.text += "\n" + ">YiZheng apparently hates his brother. He’s already trying to pin the accident on JingHui. Could his hatred be a possible motive? Or is he right about JingHui?";
              }
            }
            if (GlobalVariables.talkedZX == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">JingHui’s secretary, XiaoJing, isn’t very talkative. She did tell me there is a J in the passcode, though.";
              }
              else
              {
                textPrint2.text += "\n" + ">JingHui’s secretary, XiaoJing, isn’t very talkative. She did tell me there is a J in the passcode, though.";
              }
            }
            if (GlobalVariables.talkedZYH == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">YingHei denies the rumor that someone paid him off to make sure JingHui never made it out of the building during the explosion. Is he telling the truth?";
              }
              else
              {
                textPrint2.text += "\n" + ">YingHei denies the rumor that someone paid him off to make sure JingHui never made it out of the building during the explosion. Is he telling the truth?";
              }
            }
            if (GlobalVariables.talkedWS == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">ShaoTing is pretty eager about this whole case. She seems to think PinBi and YongRuan are up to something.";
              }
              else
              {
                textPrint2.text += "\n" + ">ShaoTing is pretty eager about this whole case. She seems to think PinBi and YongRuan are up to something.";
              }
            }
            if (GlobalVariables.talkedZYR == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">YongRuan and JingHui seem to have some history. She’s worth keeping an eye on.";
              }
              else
              {
                textPrint2.text += "\n" + ">YongRuan and JingHui seem to have some history. She’s worth keeping an eye on.";
              }
            }
            if (GlobalVariables.talkedLP == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">PinBi doesn’t like me very much. He’s very quick to name names, with no good reason. I wonder if he’s just trying to save his own skin.";
              }
              else
              {
                textPrint2.text += "\n" + ">PinBi doesn’t like me very much. He’s very quick to name names, with no good reason. I wonder if he’s just trying to save his own skin.";
              }
            }
            if (GlobalVariables.talkedLM == true)
            {
              if (textPrint2.text == "")
              {
                textPrint2.text += ">The Janitor is kind of odd. He won’t talk to me. He just keeps repeating the letter Z.";
              }
              else
              {
                textPrint2.text += "\n" + ">The Janitor is kind of odd. He won’t talk to me. He just keeps repeating the letter Z.";
              }
            }

            if (textPrint2.text == "")
            {
              textPrint2.text += "Haven't Talked to Anybory Yet...";
            }

            if (Input.GetKeyDown("n"))
            {
                print("N key was pressed");
                SceneManager.LoadScene("NotebookHints");
            }
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                print("Escape key was pressed");
                SceneManager.LoadScene(GlobalVariables.sceneNameSaver);
            }


        }

    }
}
