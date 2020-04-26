using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notebook3 : MonoBehaviour
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

  //level2
  public GameObject MeiImpression2;
  public GameObject MinKaiImpression2;
  public GameObject PinBiImpression2;
  public GameObject SuRongImpression2;
  public GameObject XiaoJingImpression2;
  public GameObject YiZhengImpression2;
  public GameObject YongRuanImpression2;


  public GameObject MeiImpression2Text;
  public GameObject MinKaiImpression2Text;
  public GameObject PinBiImpression2Text;
  public GameObject SuRongImpression2Text;
  public GameObject XiaoJingImpression2Text;
  public GameObject YiZhengImpression2Text;
  public GameObject YongRuanImpression2Text;

  public GameObject Level2Hints;
  public GameObject IntroHint;
  public GameObject ElevatorHint;
  public GameObject FuseHint;
  public GameObject DrawerHint;
  public GameObject MagnetHint;
  public GameObject HoleHint;
  public GameObject MedicalReportHint;
  public GameObject OrangeHint;

  public GameObject IntroHintText;
  public GameObject ElevatorHintText;
  public GameObject FuseHintText;
  public GameObject DrawerHintText;
  public GameObject MagnetHintText;
  public GameObject HoleHintText;
  public GameObject MedicalReportHintText;
  public GameObject OrangeHintText;

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

    //level2
    /*Mei2.SetActive(false);
    MinKai2.SetActive(false);
    PinBi2.SetActive(false);
    SuRong2.SetActive(false);
    XiaoJing2.SetActive(false);
    YiZheng2.SetActive(false);
    YongRuan2.SetActive(false);
    BackButton7.SetActive(false);*/

    MeiImpression2.SetActive(false);
    MinKaiImpression2.SetActive(false);
    PinBiImpression2.SetActive(false);
    SuRongImpression2.SetActive(false);
    XiaoJingImpression2.SetActive(false);
    YiZhengImpression2.SetActive(false);
    YongRuanImpression2.SetActive(false);

    MeiImpression2Text.SetActive(false);
    MinKaiImpression2Text.SetActive(false);
    PinBiImpression2Text.SetActive(false);
    SuRongImpression2Text.SetActive(false);
    XiaoJingImpression2Text.SetActive(false);
    YiZhengImpression2Text.SetActive(false);
    YongRuanImpression2Text.SetActive(false);

    Level2Hints.SetActive(false);
    IntroHint.SetActive(false);
    ElevatorHint.SetActive(false);
    FuseHint.SetActive(false);
    DrawerHint.SetActive(false);
    MagnetHint.SetActive(false);
    HoleHint.SetActive(false);
    MedicalReportHint.SetActive(false);
    OrangeHint.SetActive(false);

    IntroHintText.SetActive(false);
    ElevatorHintText.SetActive(false);
    FuseHintText.SetActive(false);
    DrawerHintText.SetActive(false);
    MagnetHintText.SetActive(false);
    HoleHintText.SetActive(false);
    MedicalReportHintText.SetActive(false);
    OrangeHintText.SetActive(false);
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

        Mei.SetActive(true);
        MinKai.SetActive(true);
        PinBi.SetActive(true);
        ShaoTing.SetActive(true);
        SuRong.SetActive(true);
        XiaoJing.SetActive(true);
        YingHei.SetActive(true);
        YiZheng.SetActive(true);
        YongRuan.SetActive(true);

///////////////////////////////

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
      MeiImpression2.SetActive(true);
      BackButton2.SetActive(true);
    }
    public void MinKai_()
    {
      TurnOff();
      MinKaiImpression1.SetActive(true);
      MinKaiImpression2.SetActive(true);
      BackButton2.SetActive(true);
    }
    public void PinBi_()
    {
      TurnOff();
      PinBiImpression1.SetActive(true);
      PinBiImpression2.SetActive(true);
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
      SuRongImpression2.SetActive(true);
      BackButton2.SetActive(true);
    }
    public void XiaoJing_()
    {
      TurnOff();
      XiaoJingImpression1.SetActive(true);
      XiaoJingImpression2.SetActive(true);
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
      YiZhengImpression2.SetActive(true);
      BackButton2.SetActive(true);
    }
    public void YongRuan_()
    {
      TurnOff();
      YongRuanImpression1.SetActive(true);
      YongRuanImpression2.SetActive(true);
      BackButton2.SetActive(true);
    }

    public void BackButton2_()
    {
      Impressions();
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

    public void MeiImp2()
    {
      TurnOff();
      MeiImpression2Text.SetActive(true);
      BackButton3.SetActive(true);

    }
    public void MinKaiImp2()
    {
      TurnOff();
      MinKaiImpression2Text.SetActive(true);
      BackButton3.SetActive(true);

    }
    public void PinBiImp2()
    {
      TurnOff();
      PinBiImpression2Text.SetActive(true);
      BackButton3.SetActive(true);

    }
    public void SuRongImp2()
    {
      TurnOff();
      SuRongImpression2Text.SetActive(true);
      BackButton3.SetActive(true);

    }
    public void XiaoJingImp2()
    {
      TurnOff();
      XiaoJingImpression2Text.SetActive(true);
      BackButton3.SetActive(true);

    }
    public void YiZhengImp2()
    {
      TurnOff();
      YiZhengImpression2Text.SetActive(true);
      BackButton3.SetActive(true);

    }
    public void YongRuanImp2()
    {
      TurnOff();
      YongRuanImpression2Text.SetActive(true);
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
      Level2Hints.SetActive(true);
      BackButton4.SetActive(true);
    }

    public void OfficeHints_()
    {
      TurnOff();
      KeyCardHint.SetActive(true);
      NewsHint.SetActive(true);
      EmailHint.SetActive(true);
      Email2Hint.SetActive(true);
      JanitorHint.SetActive(true);
      XiaoJingHint.SetActive(true);

      BackButton5.SetActive(true);
    }

    public void BackButton5_()
    {
      TurnOff();
      OfficeHints.SetActive(true);
      Level2Hints.SetActive(true);
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

    public void Level2Hints_()
    {
      TurnOff();
      IntroHint.SetActive(true);
      ElevatorHint.SetActive(true);
      FuseHint.SetActive(true);
      DrawerHint.SetActive(true);
      MagnetHint.SetActive(true);
      HoleHint.SetActive(true);
      MedicalReportHint.SetActive(true);
      OrangeHint.SetActive(true);

      BackButton5.SetActive(true);
    }

    public void IntroHint_()
    {
      TurnOff();
      IntroHintText.SetActive(true);
      BackButton6.SetActive(true);
    }

    public void ElevatorHint_()
    {
      TurnOff();
      ElevatorHintText.SetActive(true);
      BackButton6.SetActive(true);

    }

    public void FuseHint_()
    {
      TurnOff();
      FuseHintText.SetActive(true);
      BackButton6.SetActive(true);

    }

    public void DrawerHint_()
    {
      TurnOff();
      DrawerHintText.SetActive(true);
      BackButton6.SetActive(true);

    }

    public void MagnetHint_()
    {
      TurnOff();
      MagnetHintText.SetActive(true);
      BackButton6.SetActive(true);

    }

    public void HoleHint_()
    {
      TurnOff();
      HoleHintText.SetActive(true);
      BackButton6.SetActive(true);

    }
    public void MedicalReportHint_()
    {
      TurnOff();
      MedicalReportHintText.SetActive(true);
      BackButton6.SetActive(true);

    }
    public void OrangeHint_()
    {
      TurnOff();
      OrangeHintText.SetActive(true);
      BackButton6.SetActive(true);

    }


    public void Quit()
    {
      Application.Quit();
    }
    /*
    public GameObject NotebookCanvas;
    public GameObject Mei;
    public GameObject MinKai;
    public GameObject PinBi;
    public GameObject SuRong;
    public GameObject XiaoJing;
    public GameObject YiZheng;
    public GameObject YongRuan;

    bool firstImpressionsUp = false;

    // Start is called before the first frame update
    void Start()
    {
      NotebookCanvas.SetActive(false);
      Mei.SetActive(false);
      MinKai.SetActive(false);
      PinBi.SetActive(false);
      SuRong.SetActive(false);
      XiaoJing.SetActive(false);
      YiZheng.SetActive(false);
      YongRuan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown("n"))
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

        if (GlobalVariables.noteMei2)
        {
          Mei.SetActive(true);
        }
        if (GlobalVariables.noteMinKai2)
        {
          MinKai.SetActive(true);
        }
        if (GlobalVariables.notePinBi2)
        {
          PinBi.SetActive(true);
        }
        if (GlobalVariables.noteSuRong2)
        {
          SuRong.SetActive(true);
        }
        if (GlobalVariables.noteXiaoJing2)
        {
          XiaoJing.SetActive(true);
        }
        if (GlobalVariables.noteYiZheng2)
        {
          YiZheng.SetActive(true);
        }
        if (GlobalVariables.noteYongRuan2)
        {
          YongRuan.SetActive(true);
        }
      }



      if (firstImpressionsUp == false)
      {
        NotebookCanvas.SetActive(false);

        if (GlobalVariables.noteMei2)
        {
          Mei.SetActive(false);
        }
        if (GlobalVariables.noteMinKai2)
        {
          MinKai.SetActive(false);
        }
        if (GlobalVariables.notePinBi2)
        {
          PinBi.SetActive(false);
        }
        if (GlobalVariables.noteSuRong2)
        {
          SuRong.SetActive(false);
        }
        if (GlobalVariables.noteXiaoJing2)
        {
          XiaoJing.SetActive(false);
        }
        if (GlobalVariables.noteYiZheng2)
        {
          YiZheng.SetActive(false);
        }
        if (GlobalVariables.noteYongRuan2)
        {
          YongRuan.SetActive(false);
        }
      }
    }*/
}
