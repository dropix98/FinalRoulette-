using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public GameObject audio;
    // Start is called before the first frame update
    void Start()
    {
      Scene currentScene1 = SceneManager.GetActiveScene();
      if (currentScene1.name == "Floor1Final" && GlobalVariables.music1Started == false)
      {
        DontDestroyOnLoad(audio);
        audio.GetComponent<AudioSource>().Play();
        GlobalVariables.music1Started = true;
      }/*
      if (currentScene1.name == "Lounge")// && GlobalVariables.music2Started == false)
      {
        //DontDestroyOnLoad(audio);
        audio.GetComponent<AudioSource>().Play();
        //GlobalVariables.music2Started = true;
      }
      if (currentScene1.name == "Level4" && GlobalVariables.music3Started == false)
      {
        DontDestroyOnLoad(audio);
        audio.GetComponent<AudioSource>().Play();
        GlobalVariables.music3Started = true;
      }
      if (currentScene1.name == "Infirmary")// && GlobalVariables.music4Started == false)
      {
        //DontDestroyOnLoad(audio);
        audio.GetComponent<AudioSource>().Play();
        //GlobalVariables.music4Started = true;
      }
      if (currentScene1.name == "BroadcastingRoom")// && GlobalVariables.music5Started == false)
      {
        //DontDestroyOnLoad(audio);
        audio.GetComponent<AudioSource>().Play();
        //GlobalVariables.music5Started = true;
      }*/
    }

    // Update is called once per frame
    void Update()
    {
      Scene currentScene = SceneManager.GetActiveScene();
      if (currentScene.name == "Loading1")
      {
        audio.GetComponent<AudioSource>().Stop();
      }/*
      if (currentScene.name == "Loading3")
      {
        audio.GetComponent<AudioSource>().Stop();
      }
      if (currentScene.name == "Loading5")
      {
        audio.GetComponent<AudioSource>().Stop();
      }*/
    }
}
