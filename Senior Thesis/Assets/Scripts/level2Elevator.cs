using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class level2Elevator : MonoBehaviour
{
    char[] colors = new char[3];

    // Start is called before the first frame update
    void Start()
    {
      colors[0] = 'z';
      colors[1] = 'z';
      colors[2] = 'z';

    }

    // Update is called once per frame
    void Update()
    {
      if (colors[2] == 'b' && colors[1] == 'r' && colors[0] == 'g')
      {
        SceneManager.LoadScene("Loading3");
      }
    }

    public void setColorBlue()
    {
      print("b");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = 'b';
      foreach( char x in colors)
      {
        Debug.Log( x.ToString());
      }
    }
    public void setColorRed()
    {
      Debug.Log("r");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = 'r';
      foreach( char x in colors)
      {
        Debug.Log( x.ToString());
      }
    }
    public void setColorGreen()
    {
      Debug.Log("g");
      colors[0] = colors[1];
      colors[1] = colors[2];
      colors[2] = 'g';
      foreach( char x in colors)
      {
        Debug.Log( x.ToString());
      }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
        {
            Debug.Log("Player Detected");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Level2-Elevator");
            }
        }
    }
}
