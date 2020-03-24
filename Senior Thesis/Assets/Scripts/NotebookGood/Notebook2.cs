using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notebook2 : MonoBehaviour
{
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
    }
}
