using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalKeypad : MonoBehaviour
{
    public InputField keypad;
    bool escape;
    public string temp;

    //public GameObject tester;
    // Start is called before the first frame update
    void Start()
    {
        //tester.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

      if(Input.GetKeyDown(KeyCode.Escape))
      {
          print("Escape key was pressed");
          SceneManager.LoadScene("Floor1Final");
      }


        keypad.ActivateInputField();
        keypad.text = keypad.text.ToUpper();
        temp = keypad.text.ToString();
        if(Input.GetKeyDown(KeyCode.Return))
        {
          CheckCorrect();

          if(CheckCorrect() == true)
          {
              //Some Scene for the door open to get out or something.
              SceneManager.LoadScene("Level1Done");
              //tester.gameObject.SetActive(true);
          }
          //GlobalVariables.inKeycardGuesser = false;
        }

    }

    public bool CheckCorrect()
    {
        if(temp == "OJSZA")
        {
            escape = true;
            return escape;
        }
        else
        {
            escape = false;
            //GlobalVariables.inKeycardGuesser = false;
            return escape;
        }
    }
}
