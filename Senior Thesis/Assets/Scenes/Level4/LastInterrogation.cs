using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastInterrogation : MonoBehaviour
{
  public GameObject button11;
  public GameObject button12;
  public GameObject button21;
  public GameObject button22;
  public GameObject button31;
  public GameObject button41;
  public GameObject button42;
  public GameObject button51;
  public GameObject button52;
  public GameObject startButton;
  public GameObject beginButton;

  public GameObject inOfficeDialogue;
  public GameObject afterInterrogationText;
  public GameObject JingHui11;
  public GameObject JingHui12;
  public GameObject JingHui21;
  public GameObject JingHui22;
  public GameObject JingHui31;
  public GameObject JingHui41;
  public GameObject JingHui42;
  public GameObject JingHui51;
  public GameObject JingHui52;

  private bool round1Done = false;
  private bool round2Done = false;
  private bool round3Done = false;
  private bool round4Done = false;
  private bool round5Done = false;

  private bool joined = false;
  private bool startAppeared = false;
  private bool officeDone = false;
  private bool afterTextDone = false;


    // Start is called before the first frame update
    void Start()
    {
      button11.SetActive(false);
      button12.SetActive(false);
      button21.SetActive(false);
      button22.SetActive(false);
      button31.SetActive(false);
      button41.SetActive(false);
      button42.SetActive(false);
      button51.SetActive(false);
      button52.SetActive(false);
      startButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if (joined == true && GlobalVariables.currentlyTalking == false && startAppeared == false)
      {
        startButton.SetActive(true);
      }
      if (round1Done == true && GlobalVariables.currentlyTalking == false && round2Done == false)
      {
        button21.SetActive(true);
        button22.SetActive(true);
      }
      if (round2Done == true && GlobalVariables.currentlyTalking == false && round3Done == false)
      {
        button31.SetActive(true);
      }
      if (round3Done == true && GlobalVariables.currentlyTalking == false && round4Done == false)
      {
        button41.SetActive(true);
        button42.SetActive(true);
      }
      if (round4Done == true && GlobalVariables.currentlyTalking == false && round5Done == false)
      {
        button51.SetActive(true);
        button52.SetActive(true);
      }
      if (round5Done == true && GlobalVariables.currentlyTalking == false && afterTextDone == false)
      {
        button51.SetActive(false);
        button52.SetActive(false);
        officeDone = true;
        afterTextDone = true;
        afterInterrogationText.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (officeDone == true && GlobalVariables.currentlyTalking == false)
      {
        SceneManager.LoadScene("FinalRouletteGame");
      }
    }

    public void JoinGroup()
    {
      beginButton.SetActive(false);
      //startButton.SetActive(true);
      joined = true;
      inOfficeDialogue.GetComponent<DialogueTrigger>().TriggerDialogue();
    }

    public void StartInterrogation()
    {
      startAppeared = true;
      button11.SetActive(true);
      button12.SetActive(true);
      startButton.SetActive(false);
    }

    public void Round11()
    {
      button11.SetActive(false);
      button12.SetActive(false);
      round1Done = true;
      JingHui11.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round12()
    {
      button11.SetActive(false);
      button12.SetActive(false);
      round1Done = true;
      JingHui12.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round21()
    {
      button21.SetActive(false);
      button22.SetActive(false);
      round2Done = true;
      JingHui21.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round22()
    {
      button21.SetActive(false);
      button22.SetActive(false);
      round2Done = true;
      JingHui22.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round31()
    {
      button31.SetActive(false);
      round3Done = true;
      JingHui31.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round41()
    {
      button41.SetActive(false);
      button42.SetActive(false);
      round4Done = true;
      JingHui41.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round42()
    {
      button41.SetActive(false);
      button42.SetActive(false);
      round4Done = true;
      JingHui42.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round51()
    {
      button51.SetActive(false);
      button52.SetActive(false);
      round5Done = true;
      JingHui51.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    public void Round52()
    {
      button51.SetActive(false);
      button52.SetActive(false);
      round5Done = true;
      JingHui52.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
}
