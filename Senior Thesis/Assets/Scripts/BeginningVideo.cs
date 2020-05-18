using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;
using UnityEngine.SceneManagement;

public class BeginningVideo : MonoBehaviour
{
    public GameObject Animatic;

    public double time;
    public double currentTime;
    // Start is called before the first frame update
    void Start()
    {
      time = Animatic.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
      checkPlayingVideo();

    }

    private void checkPlayingVideo()
    {
      Scene currentScene = SceneManager.GetActiveScene();
      currentTime = Animatic.GetComponent<VideoPlayer>().time;
       if (currentTime >= time-.042)
       {
         Debug.Log ("Video Over");

         if (currentScene.name == "BeginAnimatic")
         {
           SceneManager.LoadScene("LoadingStart");
         }
         if (currentScene.name == "LogoVideo")
         {
           SceneManager.LoadScene("MainMenuFinal");
         }
       }
     }
}
