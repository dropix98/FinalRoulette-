using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    char[] colors = new char[7];
    bool level1 = false;
    bool level2 = false;
    bool level3 = false;
    bool level4 = false;
    bool level5 = false;
    bool level6 = false;
    bool level7 = false;

    public GameObject blue;
    public GameObject pink;
    public GameObject green;
    public GameObject yellow;


    public float delay = 5F;
    private float remainingTime;


    // Start is called before the first frame update
    void Start()
    {
      blue.SetActive(false);
      yellow.SetActive(false);
      green.SetActive(false);
      pink.SetActive(false);

      remainingTime = delay;

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
        }

      }
    }

    public void startGame()
    {
      level1 = true;
    }

    public void Level1Check()
    {
      
    }

    public void setBlue()
    {
      print("b");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'b';

    }
    public void setPink()
    {
      Debug.Log("p");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'r';

    }
    public void setYellow()
    {
      Debug.Log("y");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'g';

    }
    public void setGreen()
    {
      Debug.Log("g");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = colors[3];
      colors[3] = colors[4];
      colors[4] = colors[5];
      colors[5] = colors[6];
      colors[6] = 'g';

    }
}
