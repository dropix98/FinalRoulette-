﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Floor1Final");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
