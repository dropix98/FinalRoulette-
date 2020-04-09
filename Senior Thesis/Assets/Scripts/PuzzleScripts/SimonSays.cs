using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimonSays : MonoBehaviour
{
    char[] colors = new char[7];


    public GameObject blue;
    public GameObject pink;
    public GameObject green;
    public GameObject yellow;
    string concat;
    bool resetString2 = true;
    bool resetString3 = true;
    bool resetString4 = true;
    bool resetString5 = true;
    bool resetString6 = true;
    bool resetString7 = true;



    public float delay = 0.5F;
    private float remainingTime;

    public bool Check2 = true;

    bool level1;
    bool level2;
    bool level2_;
    bool level3;
    bool level3_;
    bool level3__;
    bool level4;
    bool level4_;
    bool level4__;
    bool level4___;
    bool level5;
    bool level5_;
    bool level5__;
    bool level5___;
    bool level5____;
    bool level6;
    bool level6_;
    bool level6__;
    bool level6___;
    bool level6____;
    bool level6_____;
    bool level7;
    bool level7_;
    bool level7__;
    bool level7___;
    bool level7____;
    bool level7_____;
    bool level7______;



    // Start is called before the first frame update
    void Start()
    {
      blue.SetActive(false);
      yellow.SetActive(false);
      green.SetActive(false);
      pink.SetActive(false);

      remainingTime = delay;

      level1 = false;
      level2 = false;
      level2_ = false;
      level3 = false;
      level4 = false;
      level5 = false;
      level6 = false;
      level7 = false;
      for ( int i = 0; i < colors.Length; i++)
      {
        colors[i] = 'z';
      }

    }

    // Update is called once per frame
    void Update()
    {
      if (level1)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
         remainingTime -= Time.deltaTime;
        }
        else
        {
         //remainingTime = delay;
         blue.SetActive(false);
         Level1Check();
        }
      }

      if (level2)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level2 = false;
          level2_ = true;
          remainingTime = delay;
        }
      }
      if (level2_)
      {
        if(remainingTime > 0)
        {
          pink.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          pink.SetActive(false);
          Level2Check();
        }
      }

      if (level3)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level3 = false;
          level3_ = true;
          remainingTime = delay;
        }
      }
      if (level3_)
      {
        if(remainingTime > 0)
        {
          pink.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          pink.SetActive(false);
          level3_ = false;
          level3__ = true;
          remainingTime = delay;
        }
      }
      if (level3__)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          Level3Check();
        }
      }

      if (level4)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level4 = false;
          level4_ = true;
          remainingTime = delay;
        }
      }
      if (level4_)
      {
        if(remainingTime > 0)
        {
          pink.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          pink.SetActive(false);
          level4_ = false;
          level4__ = true;
          remainingTime = delay;
        }
      }
      if (level4__)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level4__ = false;
          level4___ = true;
          remainingTime = delay;
        }
      }
      if (level4___)
      {
        if(remainingTime > 0)
        {
          yellow.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          yellow.SetActive(false);
          Level4Check();
        }
      }

      if (level5)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level5 = false;
          level5_ = true;
          remainingTime = delay;
        }
      }
      if (level5_)
      {
        if(remainingTime > 0)
        {
          pink.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          pink.SetActive(false);
          level5_ = false;
          level5__ = true;
          remainingTime = delay;
        }
      }
      if (level5__)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level5__ = false;
          level5___ = true;
          remainingTime = delay;
        }
      }
      if (level5___)
      {
        if(remainingTime > 0)
        {
          yellow.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          yellow.SetActive(false);
          level5___ = false;
          level5____ = true;
          remainingTime = delay;
        }
      }
      if (level5____)
      {
        if(remainingTime > 0)
        {
          green.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          green.SetActive(false);
          Level5Check();
        }
      }

      if (level6)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level6 = false;
          level6_ = true;
          remainingTime = delay;
        }
      }
      if (level6_)
      {
        if(remainingTime > 0)
        {
          pink.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          pink.SetActive(false);
          level6_ = false;
          level6__ = true;
          remainingTime = delay;
        }
      }
      if (level6__)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level6__ = false;
          level6___ = true;
          remainingTime = delay;
        }
      }
      if (level6___)
      {
        if(remainingTime > 0)
        {
          yellow.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          yellow.SetActive(false);
          level6___ = false;
          level6____ = true;
          remainingTime = delay;
        }
      }
      if (level6____)
      {
        if(remainingTime > 0)
        {
          green.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          green.SetActive(false);
          level6____ = false;
          level6_____ = true;
          remainingTime = delay;
        }
      }
      if (level6_____)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          Level6Check();
        }
      }

      if (level7)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level7 = false;
          level7_ = true;
          remainingTime = delay;
        }
      }
      if (level7_)
      {
        if(remainingTime > 0)
        {
          pink.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          pink.SetActive(false);
          level7_ = false;
          level7__ = true;
          remainingTime = delay;
        }
      }
      if (level7__)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level7__ = false;
          level7___ = true;
          remainingTime = delay;
        }
      }
      if (level7___)
      {
        if(remainingTime > 0)
        {
          yellow.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          yellow.SetActive(false);
          level7___ = false;
          level7____ = true;
          remainingTime = delay;
        }
      }
      if (level7____)
      {
        if(remainingTime > 0)
        {
          green.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          green.SetActive(false);
          level7____ = false;
          level7_____ = true;
          remainingTime = delay;
        }
      }
      if (level7_____)
      {
        if(remainingTime > 0)
        {
          blue.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          blue.SetActive(false);
          level7_____ = false;
          level7______ = true;
          remainingTime = delay;
        }
      }
      if (level7______)
      {
        if(remainingTime > 0)
        {
          yellow.SetActive(true);
          remainingTime -= Time.deltaTime;
        }
        else
        {
          yellow.SetActive(false);
          Level7Check();
        }
      }

    }

    public void startGame()
    {
      level1 = true;
    }

    public void Level1Check()
    {
      if (colors[0] == 'b')
      {
        level1 = false;
        level2 = true;
        remainingTime = delay;
      }
      else if (colors[0] == 'y' || colors[6] == 'p' || colors[6] == 'g')
      {
        FailGame();
      }
    }

    public void Level2Check()
    {
        if (resetString2)
        {
          for ( int i = 0; i < colors.Length; i++)
          {
            colors[i] = 'z';
          }
          resetString2 = false;
        }
        //print ("start");

        if (colors[1] == 'p' && colors[0] == 'b')
        {
          level2_ = false;
          level3 = true;
          remainingTime = delay;
          print ("hello");
        }
        else if (colors[1] == 'y' || colors[1] == 'b' || colors[1] == 'g' ||
                 colors[0] == 'y' || colors[0] == 'p' || colors[0] == 'g')
        {
          FailGame();
        }

    }

    public void Level3Check()
    {
        if (resetString3)
        {
          for ( int i = 0; i < colors.Length; i++)
          {
            colors[i] = 'z';
          }
          resetString3 = false;
        }
        //print ("start");

        if (colors[2] == 'b' && colors[1] == 'p' && colors[0] == 'b')
        {
          level3__ = false;
          level4 = true;
          remainingTime = delay;
          print ("hello");
        }
        else if (colors[2] == 'y' || colors[2] == 'p' || colors[2] == 'g' ||
                 colors[1] == 'y' || colors[1] == 'b' || colors[1] == 'g' ||
                 colors[0] == 'y' || colors[0] == 'p' || colors[0] == 'g')
        {
          FailGame();
        }

    }

    public void Level4Check()
    {
        if (resetString4)
        {
          for ( int i = 0; i < colors.Length; i++)
          {
            colors[i] = 'z';
          }
          resetString4 = false;
        }
        //print ("start");

        if (colors[3] == 'y' && colors[2] == 'b' && colors[1] == 'p' && colors[0] == 'b')
        {
          level4___ = false;
          level5 = true;
          remainingTime = delay;
          print ("hello");
        }
        else if (colors[3] == 'b' || colors[3] == 'p' || colors[3] == 'g' ||
                 colors[2] == 'y' || colors[2] == 'p' || colors[2] == 'g' ||
                 colors[1] == 'y' || colors[1] == 'b' || colors[1] == 'g' ||
                 colors[0] == 'y' || colors[0] == 'p' || colors[0] == 'g')
        {
          FailGame();
        }

    }

    public void Level5Check()
    {
        if (resetString5)
        {
          for ( int i = 0; i < colors.Length; i++)
          {
            colors[i] = 'z';
          }
          resetString5 = false;
        }
        //print ("start");

        if (colors[4] == 'g' && colors[3] == 'y' && colors[2] == 'b' && colors[1] == 'p' && colors[0] == 'b')
        {
          level5____ = false;
          level6 = true;
          remainingTime = delay;
          print ("hello");
        }
        else if (colors[4] == 'b' || colors[4] == 'p' || colors[4] == 'y' ||
                 colors[3] == 'b' || colors[3] == 'p' || colors[3] == 'g' ||
                 colors[2] == 'y' || colors[2] == 'p' || colors[2] == 'g' ||
                 colors[1] == 'y' || colors[1] == 'b' || colors[1] == 'g' ||
                 colors[0] == 'y' || colors[0] == 'p' || colors[0] == 'g')
        {
          FailGame();
        }

    }

    public void Level6Check()
    {
        if (resetString6)
        {
          for ( int i = 0; i < colors.Length; i++)
          {
            colors[i] = 'z';
          }
          resetString6 = false;
        }
        //print ("start");

        if (colors[5] == 'b' && colors[4] == 'g' && colors[3] == 'y' && colors[2] == 'b' && colors[1] == 'p' && colors[0] == 'b')
        {
          level6_____ = false;
          level7 = true;
          remainingTime = delay;
          print ("hello");
        }
        else if (colors[5] == 'g' || colors[5] == 'p' || colors[5] == 'y' ||
                 colors[4] == 'b' || colors[4] == 'p' || colors[4] == 'y' ||
                 colors[3] == 'b' || colors[3] == 'p' || colors[3] == 'g' ||
                 colors[2] == 'y' || colors[2] == 'p' || colors[2] == 'g' ||
                 colors[1] == 'y' || colors[1] == 'b' || colors[1] == 'g' ||
                 colors[0] == 'y' || colors[0] == 'p' || colors[0] == 'g')
        {
          FailGame();
        }

    }

    public void Level7Check()
    {
        if (resetString7)
        {
          for ( int i = 0; i < colors.Length; i++)
          {
            colors[i] = 'z';
          }
          resetString7 = false;
        }
        //print ("start");

        if (colors[6] == 'y' && colors[5] == 'b' && colors[4] == 'g' && colors[3] == 'y' && colors[2] == 'b' && colors[1] == 'p' && colors[0] == 'b')
        {
          level7______ = false;
          print ("Beat Simon Says");
            SceneManager.LoadScene("BroadcastingRoom");
        }
        else if (colors[6] == 'g' || colors[6] == 'p' || colors[6] == 'b' ||
                 colors[5] == 'g' || colors[5] == 'p' || colors[5] == 'y' ||
                 colors[4] == 'b' || colors[4] == 'p' || colors[4] == 'y' ||
                 colors[3] == 'b' || colors[3] == 'p' || colors[3] == 'g' ||
                 colors[2] == 'y' || colors[2] == 'p' || colors[2] == 'g' ||
                 colors[1] == 'y' || colors[1] == 'b' || colors[1] == 'g' ||
                 colors[0] == 'y' || colors[0] == 'p' || colors[0] == 'g')
        {
          FailGame();
        }

    }

    public void FailGame()
    {
      SceneManager.LoadScene("BroadcastingRoom");
    }

    public void setBlue()
    {
      print("b");
      for ( int i = 0; i < colors.Length; i++)
      {
        if (colors[i] == 'z')
        {
          colors[i] = 'b';
          break;
        }
      }

      concat = "";
      for ( int i = 0; i < colors.Length; i++)
      {
         concat = concat + colors[i];
      }
      print (concat);
      /*colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'b';*/

    }
    public void setPink()
    {
      Debug.Log("p");
      for ( int i = 0; i < colors.Length; i++)
      {
        if (colors[i] == 'z')
        {
          colors[i] = 'p';
          break;
        }
      }

      concat = "";

      for ( int i = 0; i < colors.Length; i++)
      {
         concat = concat + colors[i];
      }
      print (concat);
      /*colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'p';*/

    }
    public void setYellow()
    {
      Debug.Log("y");
      for ( int i = 0; i < colors.Length; i++)
      {
        if (colors[i] == 'z')
        {
          colors[i] = 'y';
          break;
        }
      }
      concat = "";

      for ( int i = 0; i < colors.Length; i++)
      {
         concat = concat + colors[i];
      }
      print (concat);
      /*colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'y';*/

    }
    public void setGreen()
    {
      Debug.Log("g");
      for ( int i = 0; i < colors.Length; i++)
      {
        if (colors[i] == 'z')
        {
          colors[i] = 'g';
          break;
        }
      }
      concat = "";


      for ( int i = 0; i < colors.Length; i++)
      {
         concat = concat + colors[i];
      }
      print (concat);
      /*colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'g';*/

    }
}
