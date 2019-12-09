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

    public GameObject tester;
    // Start is called before the first frame update
    void Start()
    {
        tester.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        keypad.ActivateInputField();
        temp = keypad.text.ToString();
        CheckCorrect();
        if(CheckCorrect() == true)
        {
            //Some Scene for the door open to get out or something.
            //SceneManager.LoadScene("DoorOpened");
            tester.gameObject.SetActive(true);
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
            return escape;
        }
    }
}
