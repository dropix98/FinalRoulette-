using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System;


public class Tutorial : MonoBehaviour
{
    public GameObject Footage;
    public double time;
    public double currentTime;
    // Start is called before the first frame update
    void Start()
    {
      time = Footage.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
      checkPlaying();
    }

    private void checkPlaying()
    {
      Scene currentScene = SceneManager.GetActiveScene();
      currentTime = Footage.GetComponent<VideoPlayer>().time;
       if (currentTime >= time-.0000006)
       {
           Debug.Log ("Video Over");
           if (currentScene.name == "BlockTutorial")
           {
             SceneManager.LoadScene("BlockPuzzle");
           }
           if (currentScene.name == "ElectricSlideTutorial")
           {
             SceneManager.LoadScene("ElectricSlidePuzzle");
           }
           if (currentScene.name == "SimonSaysTutorial")
           {
             SceneManager.LoadScene("SimonSays");
           }
           if (currentScene.name == "KeycardTutorial")
           {
             SceneManager.LoadScene("FinalKeycardGuesser");
           }
       }
     }
}
