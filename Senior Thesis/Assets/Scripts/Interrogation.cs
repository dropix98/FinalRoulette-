using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrogation : MonoBehaviour
{
    public GameObject buttonYing;
    public GameObject buttonSuRong;
    public GameObject buttonYiZheng;
    public GameObject buttonXiaoJing;
    public GameObject buttonYingHei;
    public GameObject buttonShaoTing;
    public GameObject buttonYongRuan;
    public GameObject buttonPinBi;
    public GameObject buttonMinKai;
    private bool choseWho = false;
    public GameObject button11;
    public GameObject button12;
    public GameObject button21;
    public GameObject button22;
    public GameObject button31;
    public GameObject button32;

    public GameObject Ying11;
    public GameObject Ying12;
    public GameObject Ying21;
    public GameObject Ying22;
    public GameObject Ying31;
    public GameObject Ying32;

    public GameObject SuRong11;
    public GameObject SuRong12;
    public GameObject SuRong21;
    public GameObject SuRong22;
    public GameObject SuRong31;
    public GameObject SuRong32;

    public GameObject YiZheng11;
    public GameObject YiZheng12;
    public GameObject YiZheng21;
    public GameObject YiZheng22;
    public GameObject YiZheng31;
    public GameObject YiZheng32;

    public GameObject XiaoJing11;
    public GameObject XiaoJing12;
    public GameObject XiaoJing21;
    public GameObject XiaoJing22;
    public GameObject XiaoJing31;
    public GameObject XiaoJing32;

    public GameObject YingHei11;
    public GameObject YingHei12;
    public GameObject YingHei21;
    public GameObject YingHei22;
    public GameObject YingHei31;
    public GameObject YingHei32;

    public GameObject ShaoTing11;
    public GameObject ShaoTing12;
    public GameObject ShaoTing21;
    public GameObject ShaoTing22;
    public GameObject ShaoTing31;
    public GameObject ShaoTing32;

    public GameObject YongRuan11;
    public GameObject YongRuan12;
    public GameObject YongRuan21;
    public GameObject YongRuan22;
    public GameObject YongRuan31;
    public GameObject YongRuan32;

    public GameObject PinBi11;
    public GameObject PinBi12;
    public GameObject PinBi21;
    public GameObject PinBi22;
    public GameObject PinBi31;
    public GameObject PinBi32;

    public GameObject MinKai11;
    public GameObject MinKai12;
    public GameObject MinKai21;
    public GameObject MinKai22;
    public GameObject MinKai31;
    public GameObject MinKai32;


    private bool round1Done = false;

    // Start is called before the first frame update
    void Start()
    {
      button11.SetActive(false);
      button12.SetActive(false);
      button21.SetActive(false);
      button22.SetActive(false);
      button31.SetActive(false);
      button32.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
      if (choseWho)
      {
        buttonYing.SetActive(false);
        buttonSuRong.SetActive(false);
        buttonYiZheng.SetActive(false);
        buttonXiaoJing.SetActive(false);
        buttonYingHei.SetActive(false);
        buttonShaoTing.SetActive(false);
        buttonYongRuan.SetActive(false);
        buttonPinBi.SetActive(false);
        buttonMinKai.SetActive(false);

      }

      if (round1Done == true && GlobalVariables.currentlyTalking == false)
      {
        button21.SetActive(true);
        button22.SetActive(true);
      }
    }




    public void InterrogateYing()
    {
      GlobalVariables.interrogatingYing = true;
      choseWho = true;
      print("chose Ying");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateSuRong()
    {
      GlobalVariables.interrogatingSuRong = true;
      choseWho = true;
      print("chose SuRong");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateYiZheng()
    {
      GlobalVariables.interrogatingYiZheng = true;
      choseWho = true;
      print("chose YiZheng");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateXiaoJing()
    {
      GlobalVariables.interrogatingXiaoJing = true;
      choseWho = true;
      print("chose XiaoJing");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateYingHei()
    {
      GlobalVariables.interrogatingYingHei = true;
      choseWho = true;
      print("chose YingHei");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateShaoTing()
    {
      GlobalVariables.interrogatingShaoTing = true;
      choseWho = true;
      print("chose ShaoTing");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateYongRuan()
    {
      GlobalVariables.interrogatingYongRuan = true;
      choseWho = true;
      print("chose YongRuan");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogatePinBi()
    {
      GlobalVariables.interrogatingPinBi = true;
      choseWho = true;
      print("chose PinBi");
      button11.SetActive(true);
      button12.SetActive(true);
    }
    public void InterrogateMinKai()
    {
      GlobalVariables.interrogatingMinKai = true;
      choseWho = true;
      print("chose MinKai");
      button11.SetActive(true);
      button12.SetActive(true);
    }




    public void Round11()
    {
      if (GlobalVariables.interrogatingYing == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        Ying11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingSuRong == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        SuRong11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingYiZheng == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        YiZheng11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingXiaoJing == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        XiaoJing11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingYingHei == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        YingHei11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingShaoTing == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        ShaoTing11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingYongRuan == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        YongRuan11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingPinBi == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        PinBi11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }
      if (GlobalVariables.interrogatingMinKai == true)
      {
        button11.SetActive(false);
        button12.SetActive(false);
        round1Done = true;
        MinKai11.GetComponent<DialogueTrigger>().TriggerDialogue();
      }

    }
}
