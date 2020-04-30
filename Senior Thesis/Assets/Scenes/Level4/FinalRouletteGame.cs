using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;


public class FinalRouletteGame : MonoBehaviour
{
    public GameObject buttonApproach;

    public GameObject buttonYiZheng;
    public GameObject buttonSuRong;
    public GameObject buttonYongRuan;

    public GameObject JingHui1;
    public GameObject JingHui2;
    public GameObject JingHui3;
    public GameObject JingHui4;

    public GameObject Dropdown;
    public GameObject SubmitButton;

    public GameObject WheelFootage;

    public GameObject YiZhengEnding;
    public GameObject YongRuanEnding;
    public GameObject SuRongEnding;


    public double time;
    public double currentTime;


    private bool approached = false;
    private bool accused = false;
    private bool lost1 = false;
    private bool lost2 = false;
    private bool lost3 = false;

    // Start is called before the first frame update
    void Start()
    {
      buttonYiZheng.SetActive(false);
      buttonSuRong.SetActive(false);
      buttonYongRuan.SetActive(false);
      SubmitButton.SetActive(false);
      Dropdown.SetActive(false);

      time = WheelFootage.GetComponent<VideoPlayer>().clip.length;

    }

    // Update is called once per frame
    void Update()
    {
      checkPlayingWheel();

      if (approached == true && GlobalVariables.currentlyTalking == false && lost1 == false)
      {
        Dropdown.SetActive(true);
        SubmitButton.SetActive(true);
      }
      if (lost1 == true && GlobalVariables.currentlyTalking == false && lost2 == false && WheelFootage.active == false)
      {
        Dropdown.SetActive(true);
        SubmitButton.SetActive(true);
      }
      if (lost2 == true && GlobalVariables.currentlyTalking == false && lost3 == false && WheelFootage.active == false)
      {
        Dropdown.SetActive(true);
        SubmitButton.SetActive(true);
      }
      if (lost3 == true && GlobalVariables.currentlyTalking == false && WheelFootage.active == false && accused == false)
      {
        buttonYiZheng.SetActive(true);
        buttonSuRong.SetActive(true);
        buttonYongRuan.SetActive(true);
      }
    }

    public void Approach()
    {
      buttonApproach.SetActive(false);
      approached = true;
      JingHui1.GetComponent<DialogueTrigger>().TriggerDialogue();

    }

    public void Submit()
    {
      Dropdown.SetActive(false);
      SubmitButton.SetActive(false);
      if (lost2 == true)
      {
        lost3 = true;
      }
      if (lost1 == true)
      {
        lost2 = true;
      }
      lost1 = true;
      WheelFootage.SetActive(true);
    }

    private void checkPlayingWheel()
    {
      currentTime = WheelFootage.GetComponent<VideoPlayer>().time;
       if (currentTime >= time)
       {
           Debug.Log ("Video Over");
           WheelFootage.SetActive(false);
           if (lost1 == true && lost2 == false)
           {
             JingHui2.GetComponent<DialogueTrigger>().TriggerDialogue();
           }
           if (lost1 == true && lost2 == true && lost3 == false)
           {
             JingHui3.GetComponent<DialogueTrigger>().TriggerDialogue();
           }
           if (lost1 == true && lost2 == true && lost3 == true)
           {
             JingHui4.GetComponent<DialogueTrigger>().TriggerDialogue();
           }
       }
     }

     public void YiZhengEndingButton()
     {
       buttonYiZheng.SetActive(false);
       buttonSuRong.SetActive(false);
       buttonYongRuan.SetActive(false);
       accused = true;
       YiZhengEnding.GetComponent<DialogueTrigger>().TriggerDialogue();
     }
     public void YongRuanEndingButton()
     {
       buttonYiZheng.SetActive(false);
       buttonSuRong.SetActive(false);
       buttonYongRuan.SetActive(false);
       accused = true;
       YongRuanEnding.GetComponent<DialogueTrigger>().TriggerDialogue();
     }
     public void SuRongEndingButton()
     {
       buttonYiZheng.SetActive(false);
       buttonSuRong.SetActive(false);
       buttonYongRuan.SetActive(false);
       accused = true;
       SuRongEnding.GetComponent<DialogueTrigger>().TriggerDialogue();
     }
}
