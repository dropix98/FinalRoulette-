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

    // Start is called before the first frame update
    void Start()
    {
      //buttonYing.SetActive(false);

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
    }

    public void InterrogateYing()
    {
      GlobalVariables.interrogatingYing = true;
      choseWho = true;
      print("chose Ying");
    }
    public void InterrogateSuRong()
    {
      GlobalVariables.interrogatingSuRong = true;
      choseWho = true;
      print("chose SuRong");
    }
    public void InterrogateYiZheng()
    {
      GlobalVariables.interrogatingYiZheng = true;
      choseWho = true;
      print("chose YiZheng");
    }
    public void InterrogateXiaoJing()
    {
      GlobalVariables.interrogatingXiaoJing = true;
      choseWho = true;
      print("chose XiaoJing");
    }
    public void InterrogateYingHei()
    {
      GlobalVariables.interrogatingYingHei = true;
      choseWho = true;
      print("chose YingHei");
    }
    public void InterrogateShaoTing()
    {
      GlobalVariables.interrogatingShaoTing = true;
      choseWho = true;
      print("chose ShaoTing");
    }
    public void InterrogateYongRuan()
    {
      GlobalVariables.interrogatingYongRuan = true;
      choseWho = true;
      print("chose YongRuan");
    }
    public void InterrogatePinBi()
    {
      GlobalVariables.interrogatingPinBi = true;
      choseWho = true;
      print("chose PinBi");
    }
    public void InterrogateMinKai()
    {
      GlobalVariables.interrogatingMinKai = true;
      choseWho = true;
      print("chose MinKai");
    }
}
