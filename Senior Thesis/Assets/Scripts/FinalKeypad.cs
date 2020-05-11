using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalKeypad : MonoBehaviour
{
    public TMPro.TMP_InputField keypad;
    bool escape;
    public string temp;

    bool ret = false;

    public GameObject red;
    public GameObject green;
    //public GameObject tester;
    // Start is called before the first frame update
    void Start()
    {
        green.gameObject.SetActive(false);
        red.gameObject.SetActive(false);
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


        //keypad.ActivateInputField();
        //keypad.text = keypad.text.ToUpper();
        //temp = keypad.text.ToString();
        /*if(Input.GetKeyDown(KeyCode.Return))
        {
          CheckCorrect();

          if(CheckCorrect() == true)
          {
                //Some Scene for the door open to get out or something.
                ret = true;
              SceneManager.LoadScene("Loading1");
              //tester.gameObject.SetActive(true);
          }
          //GlobalVariables.inKeycardGuesser = false;
        }
        */

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

    public bool Ret()
    {
        return ret;
    }


    public void ButtonPress(string letr)
    {
        Resetred();
        keypad.text += letr;
        temp = keypad.text.ToString();
        CheckCorrect();
        if (CheckCorrect() == true)
        {
            //Some Scene for the door open to get out or something.
            green.gameObject.SetActive(true);
            Pause();
            ret = true;
            SceneManager.LoadScene("Loading1");
            //tester.gameObject.SetActive(true);
        }
        if(keypad.text.ToString().Length == 5 && CheckCorrect() == false)
        {
            red.gameObject.SetActive(true);
            Pause();
            Reseti();
        }
    }

    public void Reseti()
    {
        keypad.text = "";
        temp = "";
        green.gameObject.SetActive(false);
       // red.gameObject.SetActive(false);
        ret = false;
    }

    public void Resetred()
    {
        red.gameObject.SetActive(false);
    }

    private IEnumerator Pause()
    {
        yield return new WaitForSeconds(3f);
    }
}
