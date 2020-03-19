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

    bool firstImpressionsUp;

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
      if (!firstImpressionsUp)
      {
        if (Input.GetKeyDown("n"))
        {
          NotebookCanvas.SetActive(true);
          firstImpressionsUp = true;
        }
      }

      if (firstImpressionsUp)
      {
        if (Input.GetKeyDown("n"))
        {
          NotebookCanvas.SetActive(false);
          firstImpressionsUp = false;
        }


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
