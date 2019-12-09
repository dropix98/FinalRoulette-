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
        /*Check();
        if (MY.IsDone())
        {
            textScript4.SetActive(false);
        }
        */


    }

    //Get these all going by looking at trigger names and if they interact. then turn the object on to dispolay the text.
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "" && MY.IsDone() == false)
        {
            textScript4.gameObject.SetActive(true);
        }

        if (collision.name == "" && CSR.IsDone() == false)
        {
            textScript1.gameObject.SetActive(true);
        }

        if (collision.name == "" && WYZ.IsDone() == false)
        {
            textScript5.gameObject.SetActive(true);
        }

        if (collision.name == "" && ZXJ.IsDone() == false)
        {
            textScript7.gameObject.SetActive(true);
        }

        if (collision.name == "" && ZYH.IsDone() == false)
        {
            textScript8.gameObject.SetActive(true);
        }

        if (collision.name == "" && WST.IsDone() == false)
        {
            textScript6.gameObject.SetActive(true);
        }

        if (collision.name == "" && ZYR.IsDone() == false)
        {
            textScript9.gameObject.SetActive(true);
        }

        if (collision.name == "" && LPB.IsDone() == false)
        {
            textScript3.gameObject.SetActive(true);
        }

        if (collision.name == "" && LMK.IsDone() == false)
        {
            textScript2.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "")
        {
            textScript4.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript1.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript5.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript7.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript8.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript6.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript9.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript3.gameObject.SetActive(false);
        }

        if (collision.name == "")
        {
            textScript2.gameObject.SetActive(false);
        }
    }
}
