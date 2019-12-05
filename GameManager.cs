using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    static bool clue1 = true;
    static bool clue2 = false;
    static bool clue3 = false;
    static bool clue4 = false;
    static bool clue5 = false;

    public GameObject textScript1; //CSR
    public GameObject textScript2; //LMK
    public GameObject textScript3; //LPB
    public GameObject textScript4; //MY
    public GameObject textScript5; //WYZ
    public GameObject textScript6; //WST
    public GameObject textScript7; //ZXJ
    public GameObject textScript8; //ZYH
    public GameObject textScript9; //ZYR

    MeiYinText MY = new MeiYinText();
    ChengSuRongText CSR = new ChengSuRongText();
    WangYiZhengText WYZ = new WangYiZhengText();
    ZhenXiaoJingText ZXJ = new ZhenXiaoJingText();
    ZhenYingHeiText ZYH = new ZhenYingHeiText();
    WeiShaoTingText WST = new WeiShaoTingText();
    ZhuangYongRuanText ZYR = new ZhuangYongRuanText();
    LinPinBiText LPB = new LinPinBiText();
    LinMinKaiText LMK = new LinMinKaiText();

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Check();
        if (MY.IsDone())
        {
            textScript4.SetActive(false);
        }
    }

    void Reset()
    {
        textScript1.gameObject.SetActive(false);
        textScript2.gameObject.SetActive(false);
        textScript3.gameObject.SetActive(false);
        textScript4.gameObject.SetActive(false);
        textScript5.gameObject.SetActive(false);
        textScript6.gameObject.SetActive(false);
        textScript7.gameObject.SetActive(false);
        textScript8.gameObject.SetActive(false);
        textScript9.gameObject.SetActive(false);
    }

    void Check()
    {
        /*GlobalVariables.inWallCollider == true*/
        if (/*GlobalVariables.inWallCollider == true*/ Input.GetKeyDown(KeyCode.K))
        {
            if(clue1 == true && clue2 == false)
            {
                textScript4.gameObject.SetActive(true);
            }
        }
    }
}
