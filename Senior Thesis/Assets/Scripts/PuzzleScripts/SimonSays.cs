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

    public float delay = 5F;
    private float remainingTime;

    public bool Check2 = true;

    bool level1;
    bool level2;
    bool level2_;
    bool level3;
    bool level3_;
    bool level3__;
    bool level4;
    bool level5;
    bool level6;
    bool level7;

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
            //print("hi");
            //if (Check2)
            //{
              Level2Check();
              print ("hey");

              //Check2 = false;
            //}
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
            level3__ = false;
            //Level3Check();
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
        for ( int i = 0; i < colors.Length; i++)
        {
          colors[i] = 'z';
        }
        print ("start");

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

    public void FailGame()
    {
      SceneManager.LoadScene("Lounge");
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
