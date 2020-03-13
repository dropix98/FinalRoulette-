using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookManager : MonoBehaviour
{
    public static bool NotebookOut = false;

    public GameObject notebookUI;

    public GameObject mainScreen; 

    public GameObject impressionUIMenu;

    public GameObject descriptionUIMenu;

    public Text nameCharacter;

    public Text impressionShort;

    public Text impressionDescription;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (NotebookOut)
            {
                Continue();
            }
            else
            {
                Open();
            }

        }
    }

    void Continue()
    {
        notebookUI.SetActive(false);
        mainScreen.SetActive(false);
        Time.timeScale = 1f;
        NotebookOut = false; 
    }

    public void Open()
    {
        notebookUI.SetActive(true);
        mainScreen.SetActive(true);
        impressionUIMenu.SetActive(false);
        Time.timeScale = 0f;
        NotebookOut = true; 
    }

    public void Exit()
    {
        Debug.Log("game quit");
        notebookUI.SetActive(false);
        mainScreen.SetActive(false);
    }

    public void ImpressionsOpen()
    {
        Debug.Log("Open Impressions");
        impressionUIMenu.SetActive(true);
        mainScreen.SetActive(false);
        descriptionUIMenu.SetActive(false);
    }

    public void LoadImpression(Impression imp)
    {
        Debug.Log("Impression Loaded");
        impressionUIMenu.SetActive(false);
        mainScreen.SetActive(false);
        Debug.Log(descriptionUIMenu.gameObject);
        descriptionUIMenu.SetActive(true);
        nameCharacter.text = imp.nameOfCharacter;
        impressionShort.text = imp.impressionShort;
        impressionDescription.text = imp.impressionDescription;
    }

    
}
