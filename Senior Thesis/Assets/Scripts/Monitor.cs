using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class Monitor : MonoBehaviour
{
    public GameObject CCTVFootage;
    public GameObject NewsFootage;
    public GameObject CCTVButton;
    public GameObject NewsButton;

    public double time;
      public double currentTime;
    // Start is called before the first frame update
    void Start()
    {
      time = CCTVFootage.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
      checkPlayingCCTV();
      checkPlayingNews();
    }

    public void PlayNews()
    {
      //plays video
      NewsFootage.SetActive(true);
      CCTVButton.SetActive(false);
      NewsButton.SetActive(false);
    }

    public void PlayCCTV()
    {
      //plays video
      GlobalVariables.CCTVHint = true;
      CCTVFootage.SetActive(true);
      CCTVButton.SetActive(false);
      NewsButton.SetActive(false);
    }

    private void checkPlayingCCTV()
    {
      currentTime = CCTVFootage.GetComponent<VideoPlayer>().time;
       if (currentTime >= time)
       {
           Debug.Log ("Video Over");
           CCTVFootage.SetActive(false);
           NewsFootage.SetActive(false);
           CCTVButton.SetActive(true);
           NewsButton.SetActive(true);
       }
     }
     private void checkPlayingNews()
     {
       currentTime = NewsFootage.GetComponent<VideoPlayer>().time;
        if (currentTime >= time)
        {
            Debug.Log ("Video Over");
            CCTVFootage.SetActive(false);
            NewsFootage.SetActive(false);
            CCTVButton.SetActive(true);
            NewsButton.SetActive(true);
        }
      }

}
