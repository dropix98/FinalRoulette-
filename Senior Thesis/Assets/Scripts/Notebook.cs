using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    public GameObject NotebookCanvas;
    public GameObject Mei;
    public GameObject MinKai;
    public GameObject PinBi;
    public GameObject ShaoTing;
    public GameObject SuRong;
    public GameObject XiaoJing;
    public GameObject YingHei;
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
      ShaoTing.SetActive(false);
      SuRong.SetActive(false);
      XiaoJing.SetActive(false);
      YingHei.SetActive(false);
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
      }
    }
}
