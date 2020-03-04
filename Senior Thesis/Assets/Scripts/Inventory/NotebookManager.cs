using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    public static bool NotebookOut = false;

    public GameObject notebookUI;

    public GameObject mainScreen; 

    public GameObject impressionUIMenu;

    public GameObject descriptionUIMenu;

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

    void Open()
    {
        notebookUI.SetActive(true);
        mainScreen.SetActive(true);
        Time.timeScale = 0f;
        NotebookOut = true; 
    }

    public void QuitGame()
    {
        Debug.Log("game quit");
    }

    public void ImpressionsOpen()
    {
        Debug.Log("Open Impressions");
        impressionUIMenu.SetActive(true);
        mainScreen.SetActive(false);
        descriptionUIMenu.SetActive(false);
    }

    public void LoadImpression()
    {
        Debug.Log("Impression Loaded");
        impressionUIMenu.SetActive(false);
        mainScreen.SetActive(false);
        descriptionUIMenu.SetActive(true);
    }

    
}
