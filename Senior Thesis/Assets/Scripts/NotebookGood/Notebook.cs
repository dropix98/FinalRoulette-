﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notebook : MonoBehaviour
{
    public GameObject NotebookCanvas;
    public GameObject resume;
    public GameObject impressions;
    public GameObject hints;
    public GameObject quit;

    public GameObject Mei;
    public GameObject MinKai;
    public GameObject PinBi;
    public GameObject ShaoTing;
    public GameObject SuRong;
    public GameObject XiaoJing;
    public GameObject YingHei;
    public GameObject YiZheng;
    public GameObject YongRuan;
    public GameObject BackButton1;

    public GameObject MeiImpression1;
    public GameObject MinKaiImpression1;
    public GameObject PinBiImpression1;
    public GameObject ShaoTingImpression1;
    public GameObject SuRongImpression1;
    public GameObject XiaoJingImpression1;
    public GameObject YingHeiImpression1;
    public GameObject YiZhengImpression1;
    public GameObject YongRuanImpression1;
    public GameObject BackButton2;


    public GameObject MeiImpression1Text;
    public GameObject MinKaiImpression1Text;
    public GameObject PinBiImpression1Text;
    public GameObject ShaoTingImpression1Text;
    public GameObject SuRongImpression1Text;
    public GameObject XiaoJingImpression1Text;
    public GameObject YingHeiImpression1Text;
    public GameObject YiZhengImpression1Text;
    public GameObject YongRuanImpression1Text;
    public GameObject BackButton3;

    public GameObject OfficeHints;
    public GameObject BackButton4;

    public GameObject KeyCardHint;
    public GameObject NewsHint;
    public GameObject EmailHint;
    public GameObject Email2Hint;
    public GameObject JanitorHint;
    public GameObject XiaoJingHint;
    public GameObject BackButton5;

    public GameObject KeyCardHintText;
    public GameObject NewsHintText;
    public GameObject EmailHintText;
    public GameObject Email2HintText;
    public GameObject JanitorHintText;
    public GameObject XiaoJingHintText;
    public GameObject BackButton6;





    //bool firstImpressionsUp = false;
    bool canvasActive = false;

    // Start is called before the first frame update
    void Start()
    {
      NotebookCanvas.SetActive(false);
      TurnOff();
    }

    public void TurnOff()
    {
      resume.SetActive(false);
      impressions.SetActive(false);
      hints.SetActive(false);
      quit.SetActive(false);

      Mei.SetActive(false);
      MinKai.SetActive(false);
      PinBi.SetActive(false);
      ShaoTing.SetActive(false);
      SuRong.SetActive(false);
      XiaoJing.SetActive(false);
      YingHei.SetActive(false);
      YiZheng.SetActive(false);
      YongRuan.SetActive(false);
      BackButton1.SetActive(false);

      MeiImpression1.SetActive(false);
      MinKaiImpression1.SetActive(false);
      PinBiImpression1.SetActive(false);
      ShaoTingImpression1.SetActive(false);
      SuRongImpression1.SetActive(false);
      XiaoJingImpression1.SetActive(false);
      YingHeiImpression1.SetActive(false);
      YiZhengImpression1.SetActive(false);
      YongRuanImpression1.SetActive(false);
      BackButton2.SetActive(false);

      MeiImpression1Text.SetActive(false);
      MinKaiImpression1Text.SetActive(false);
      PinBiImpression1Text.SetActive(false);
      ShaoTingImpression1Text.SetActive(false);
      SuRongImpression1Text.SetActive(false);
      XiaoJingImpression1Text.SetActive(false);
      YingHeiImpression1Text.SetActive(false);
      YiZhengImpression1Text.SetActive(false);
      YongRuanImpression1Text.SetActive(false);
      BackButton3.SetActive(false);

      OfficeHints.SetActive(false);;
      BackButton4.SetActive(false);;

      KeyCardHint.SetActive(false);;
      NewsHint.SetActive(false);;
      EmailHint.SetActive(false);;
      Email2Hint.SetActive(false);;
      JanitorHint.SetActive(false);;
      XiaoJingHint.SetActive(false);;
      BackButton5.SetActive(false);;

      KeyCardHintText.SetActive(false);;
      NewsHintText.SetActive(false);;
      EmailHintText.SetActive(false);;
      Email2HintText.SetActive(false);;
      JanitorHintText.SetActive(false);;
      XiaoJingHintText.SetActive(false);;
      BackButton6.SetActive(false);;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        if (canvasActive == false)
        {
          NotebookCanvas.SetActive(true);
          canvasActive = true;
          TurnOff();
          resume.SetActive(true);
          impressions.SetActive(true);
          hints.SetActive(true);
          quit.SetActive(true);
        }
        else if (canvasActive == true)
        {
          NotebookCanvas.SetActive(false);
          canvasActive = false;
        }
      }
    }

      public void Resume()
      {
        NotebookCanvas.SetActive(false);
      }

      public void Impressions()
      {
        TurnOff();

        BackButton1.SetActive(true);

        if (GlobalVariables.noteMei)
        {
          Mei.SetActive(true);
        }
        if (GlobalVariables.noteMinKai)
        {
          MinKai.SetActive(true);
        }
        if (GlobalVariables.notePinBi)
        {
          PinBi.SetActive(true);
        }
        if (GlobalVariables.noteShaoTing)
        {
          ShaoTing.SetActive(true);
        }
        if (GlobalVariables.noteSuRong)
        {
          SuRong.SetActive(true);
        }
        if (GlobalVariables.noteXiaoJing)
        {
          XiaoJing.SetActive(true);
        }
        if (GlobalVariables.noteYingHei)
        {
          YingHei.SetActive(true);
        }
        if (GlobalVariables.noteYiZheng)
        {
          YiZheng.SetActive(true);
        }
        if (GlobalVariables.noteYongRuan)
        {
          YongRuan.SetActive(true);
        }


      }

      public void BackButton1_()
      {
        TurnOff();
        resume.SetActive(true);
        impressions.SetActive(true);
        hints.SetActive(true);
        quit.SetActive(true);
      }

      public void Mei_()
      {
        TurnOff();
        MeiImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void MinKai_()
      {
        TurnOff();
        MinKaiImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void PinBi_()
      {
        TurnOff();
        PinBiImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void ShaoTing_()
      {
        TurnOff();
        ShaoTingImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void SuRong_()
      {
        TurnOff();
        SuRongImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void XiaoJing_()
      {
        TurnOff();
        XiaoJingImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void YingHei_()
      {
        TurnOff();
        YingHeiImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void YiZheng_()
      {
        TurnOff();
        YiZhengImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }
      public void YongRuan_()
      {
        TurnOff();
        YongRuanImpression1.SetActive(true);
        BackButton2.SetActive(true);

      }

      public void BackButton2_()
      {
        TurnOff();
        if (GlobalVariables.noteMei)
        {
          Mei.SetActive(true);
        }
        if (GlobalVariables.noteMinKai)
        {
          MinKai.SetActive(true);
        }
        if (GlobalVariables.notePinBi)
        {
          PinBi.SetActive(true);
        }
        if (GlobalVariables.noteShaoTing)
        {
          ShaoTing.SetActive(true);
        }
        if (GlobalVariables.noteSuRong)
        {
          SuRong.SetActive(true);
        }
        if (GlobalVariables.noteXiaoJing)
        {
          XiaoJing.SetActive(true);
        }
        if (GlobalVariables.noteYingHei)
        {
          YingHei.SetActive(true);
        }
        if (GlobalVariables.noteYiZheng)
        {
          YiZheng.SetActive(true);
        }
        if (GlobalVariables.noteYongRuan)
        {
          YongRuan.SetActive(true);
        }
        BackButton1.SetActive(true);

      }

      public void MeiImp1()
      {
        TurnOff();
        MeiImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void MinKaiImp1()
      {
        TurnOff();
        MinKaiImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void PinBiImp1()
      {
        TurnOff();
        PinBiImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void ShaoTingImp1()
      {
        TurnOff();
        ShaoTingImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void SuRongImp1()
      {
        TurnOff();
        SuRongImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void XiaoJingImp1()
      {
        TurnOff();
        XiaoJingImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void YingHeiImp1()
      {
        TurnOff();
        YingHeiImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void YiZhengImp1()
      {
        TurnOff();
        YiZhengImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }
      public void YongRuanImp1()
      {
        TurnOff();
        YongRuanImpression1Text.SetActive(true);
        BackButton3.SetActive(true);

      }


      /*public void BackButton3_()
      {
        TurnOff();
        MeiImpression1.SetActive(true);
        MinKaiImpression1.SetActive(true);
        PinBiImpression1.SetActive(true);
        ShaoTingImpression1.SetActive(true);
        SuRongImpression1.SetActive(true);
        XiaoJingImpression1.SetActive(true);
        YingHeiImpression1.SetActive(true);
        YiZhengImpression1.SetActive(true);
        YongRuanImpression1.SetActive(true);
        BackButton2.SetActive(true);
      }*/

      public void Hints()
      {
        TurnOff();
        OfficeHints.SetActive(true);
        BackButton4.SetActive(true);
      }

      public void OfficeHints_()
      {
        TurnOff();
        if (GlobalVariables.triedKeycardOnDoor == true)
        {
          KeyCardHint.SetActive(true);
        }
        if (GlobalVariables.foundNewsArticle == true)
        {
          NewsHint.SetActive(true);
        }
        if (GlobalVariables.foundEmail == true)
        {
          EmailHint.SetActive(true);
          Email2Hint.SetActive(true);
        }
        if (GlobalVariables.talkedJH == true)
        {
          JanitorHint.SetActive(true);
        }
        if (GlobalVariables.talkedXJ == true)
        {
          XiaoJingHint.SetActive(true);
        }
        BackButton5.SetActive(true);
      }

      public void BackButton5_()
      {
        TurnOff();
        OfficeHints.SetActive(true);
        BackButton4.SetActive(true);
      }

      public void KeyCardHint_()
      {
        TurnOff();
        KeyCardHintText.SetActive(true);
        BackButton6.SetActive(true);
      }

      public void NewsHint_()
      {
        TurnOff();
        NewsHintText.SetActive(true);
        BackButton6.SetActive(true);

      }

      public void EmailHint_()
      {
        TurnOff();
        EmailHintText.SetActive(true);
        BackButton6.SetActive(true);

      }

      public void Email2Hint_()
      {
        TurnOff();
        Email2HintText.SetActive(true);
        BackButton6.SetActive(true);

      }

      public void JanitorHint_()
      {
        TurnOff();
        JanitorHintText.SetActive(true);
        BackButton6.SetActive(true);

      }

      public void XiaoJingHint_()
      {
        TurnOff();
        XiaoJingHintText.SetActive(true);
        BackButton6.SetActive(true);

      }

      public void Quit()
      {
        Application.Quit();
      }
      /*if (Input.GetKeyDown("n"))
      {
        if (firstImpressionsUp == true)
        {
          firstImpressionsUp = false;
        }
        else
        {
          firstImpressionsUp = true;
        }
      }



      if (firstImpressionsUp == true)
      {
        NotebookCanvas.SetActive(true);

        if (GlobalVariables.noteMei)
        {
          Mei.SetActive(true);
        }
        if (GlobalVariables.noteMinKai)
        {
          MinKai.SetActive(true);
        }
        if (GlobalVariables.notePinBi)
        {
          PinBi.SetActive(true);
        }
        if (GlobalVariables.noteShaoTing)
        {
          ShaoTing.SetActive(true);
        }
        if (GlobalVariables.noteSuRong)
        {
          SuRong.SetActive(true);
        }
        if (GlobalVariables.noteXiaoJing)
        {
          XiaoJing.SetActive(true);
        }
        if (GlobalVariables.noteYingHei)
        {
          YingHei.SetActive(true);
        }
        if (GlobalVariables.noteYiZheng)
        {
          YiZheng.SetActive(true);
        }
        if (GlobalVariables.noteYongRuan)
        {
          YongRuan.SetActive(true);
        }
      }



      if (firstImpressionsUp == false)
      {
        NotebookCanvas.SetActive(false);

        if (GlobalVariables.noteMei)
        {
          Mei.SetActive(false);
        }
        if (GlobalVariables.noteMinKai)
        {
          MinKai.SetActive(false);
        }
        if (GlobalVariables.notePinBi)
        {
          PinBi.SetActive(false);
        }
        if (GlobalVariables.noteShaoTing)
        {
          ShaoTing.SetActive(false);
        }
        if (GlobalVariables.noteSuRong)
        {
          SuRong.SetActive(false);
        }
        if (GlobalVariables.noteXiaoJing)
        {
          XiaoJing.SetActive(false);
        }
        if (GlobalVariables.noteYingHei)
        {
          YingHei.SetActive(false);
        }
        if (GlobalVariables.noteYiZheng)
        {
          YiZheng.SetActive(false);
        }
        if (GlobalVariables.noteYongRuan)
        {
          YongRuan.SetActive(false);
        }
      }*/
}
