using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;
using TMPro;

public class FinalRouletteGame : MonoBehaviour
{
    public GameObject buttonApproach;

    public GameObject buttonYiZheng;
    public GameObject buttonSuRong;
    public GameObject buttonYongRuan;

    public GameObject background;
    public GameObject background2;


    public GameObject JingHui1;
    public GameObject JingHui2;
    public GameObject JingHui3;
    public GameObject JingHui4;
    public GameObject JingHui5;
    public GameObject JingHui6;
    public GameObject JingHui7;

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
    //private bool if1 = true;
    //private bool if2 = true;
    //private bool if3 = true;


    public TMP_Dropdown dropdown;
    public GameObject chip1;
    public GameObject chip2;
    public GameObject chip3;
    public GameObject chip4;
    public GameObject chip5;
    public GameObject chip6;
    public GameObject chip7;
    public GameObject chip8;
    public GameObject chip9;
    public GameObject chip10;
    public GameObject chip11;
    public GameObject chip12;
    public GameObject chip13;
    public GameObject chip14;
    public GameObject chip15;
    public GameObject chip16;
    public GameObject chip17;
    public GameObject chip18;
    public GameObject chip19;
    public GameObject chip20;
    public GameObject chip21;
    public GameObject chip22;
    public GameObject chip23;
    public GameObject chip24;
    public GameObject chip25;
    public GameObject chip26;
    public GameObject chip27;
    public GameObject chip28;
    public GameObject chip29;
    public GameObject chip30;
    public GameObject chip31;
    public GameObject chip32;
    public GameObject chip33;
    public GameObject chip34;
    public GameObject chip35;
    public GameObject chip36;

    // Start is called before the first frame update
    void Start()
    {
      buttonYiZheng.SetActive(false);
      buttonSuRong.SetActive(false);
      buttonYongRuan.SetActive(false);
      SubmitButton.SetActive(false);
      Dropdown.SetActive(false);

      time = 2.0;// WheelFootage.GetComponent<VideoPlayer>().clip.length;

    }

    // Update is called once per frame
    void Update()
    {
      checkPlayingWheel();

      if (approached == true && GlobalVariables.currentlyTalking == false && lost1 == false)
      {
        Dropdown.SetActive(true);
        SubmitButton.SetActive(true);
        /*if (if1)
        {
          JingHui5.GetComponent<DialogueTrigger>().TriggerDialogue();
          if1 = false;
        }*/
      }
      if (lost1 == true && GlobalVariables.currentlyTalking == false && lost2 == false && WheelFootage.active == false)
      {
        Dropdown.SetActive(true);
        SubmitButton.SetActive(true);
        /*if (if2)
        {
          JingHui6.GetComponent<DialogueTrigger>().TriggerDialogue();
          if2 = false;
        }*/
      }
      if (lost2 == true && GlobalVariables.currentlyTalking == false && lost3 == false && WheelFootage.active == false)
      {
        Dropdown.SetActive(true);
        SubmitButton.SetActive(true);
        /*if (if3)
        {
          JingHui7.GetComponent<DialogueTrigger>().TriggerDialogue();
          if3 = false;
        }*/
      }
      if (lost3 == true && GlobalVariables.currentlyTalking == false && WheelFootage.active == false && accused == false)
      {
        buttonYiZheng.SetActive(true);
        buttonSuRong.SetActive(true);
        buttonYongRuan.SetActive(true);
        background.SetActive(false);
        background2.SetActive(true);
      }

      if(SubmitButton.active == false)
      {
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 0 && SubmitButton.active == true)
      {
        chip1.SetActive(true);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 1 && SubmitButton.active == true)
      {
        chip2.SetActive(true);
        chip1.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 2 && SubmitButton.active == true)
      {
        chip3.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 3 && SubmitButton.active == true)
      {
        chip4.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 4 && SubmitButton.active == true)
      {
        chip5.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 5 && SubmitButton.active == true)
      {
        chip6.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 6 && SubmitButton.active == true)
      {
        chip7.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 7 && SubmitButton.active == true)
      {
        chip8.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 8 && SubmitButton.active == true)
      {
        chip9.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 9 && SubmitButton.active == true)
      {
        chip10.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 10 && SubmitButton.active == true)
      {
        chip11.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 11 && SubmitButton.active == true)
      {
        chip12.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 12 && SubmitButton.active == true)
      {
        chip13.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 13 && SubmitButton.active == true)
      {
        chip14.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 14 && SubmitButton.active == true)
      {
        chip15.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 15 && SubmitButton.active == true)
      {
        chip16.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 16 && SubmitButton.active == true)
      {
        chip17.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 17 && SubmitButton.active == true)
      {
        chip18.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 18 && SubmitButton.active == true)
      {
        chip19.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 19 && SubmitButton.active == true)
      {
        chip20.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 20 && SubmitButton.active == true)
      {
        chip21.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 21 && SubmitButton.active == true)
      {
        chip22.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 22 && SubmitButton.active == true)
      {
        chip23.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 23 && SubmitButton.active == true)
      {
        chip24.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 24 && SubmitButton.active == true)
      {
        chip25.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 25 && SubmitButton.active == true)
      {
        chip26.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 26 && SubmitButton.active == true)
      {
        chip27.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 27 && SubmitButton.active == true)
      {
        chip28.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 28 && SubmitButton.active == true)
      {
        chip29.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 29 && SubmitButton.active == true)
      {
        chip30.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 30 && SubmitButton.active == true)
      {
        chip31.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 31 && SubmitButton.active == true)
      {
        chip32.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 32 && SubmitButton.active == true)
      {
        chip33.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 33 && SubmitButton.active == true)
      {
        chip34.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip35.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 34 && SubmitButton.active == true)
      {
        chip35.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip36.SetActive(false);
      }
      if(dropdown.value == 35 && SubmitButton.active == true)
      {
        chip36.SetActive(true);
        chip1.SetActive(false);
        chip2.SetActive(false);
        chip3.SetActive(false);
        chip4.SetActive(false);
        chip5.SetActive(false);
        chip6.SetActive(false);
        chip7.SetActive(false);
        chip8.SetActive(false);
        chip9.SetActive(false);
        chip10.SetActive(false);
        chip11.SetActive(false);
        chip12.SetActive(false);
        chip13.SetActive(false);
        chip14.SetActive(false);
        chip15.SetActive(false);
        chip16.SetActive(false);
        chip17.SetActive(false);
        chip18.SetActive(false);
        chip19.SetActive(false);
        chip20.SetActive(false);
        chip21.SetActive(false);
        chip22.SetActive(false);
        chip23.SetActive(false);
        chip24.SetActive(false);
        chip25.SetActive(false);
        chip26.SetActive(false);
        chip27.SetActive(false);
        chip28.SetActive(false);
        chip29.SetActive(false);
        chip30.SetActive(false);
        chip31.SetActive(false);
        chip32.SetActive(false);
        chip33.SetActive(false);
        chip34.SetActive(false);
        chip35.SetActive(false);
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
