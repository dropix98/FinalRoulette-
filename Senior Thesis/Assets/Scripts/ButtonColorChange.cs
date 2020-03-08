using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DragonBlue()
    {
      GlobalVariables.dragonColor = "blue";
    }
    public void DragonOrange()
    {
      GlobalVariables.dragonColor = "orange";
    }
    public void DragonPurple()
    {
      GlobalVariables.dragonColor = "purple";
    }
    public void SnakeBlue()
    {
      GlobalVariables.snakeColor = "blue";
    }
    public void SnakeOrange()
    {
      GlobalVariables.snakeColor = "orange";
    }
    public void SnakePurple()
    {
      GlobalVariables.snakeColor = "purple";
    }
    public void RabbitBlue()
    {
      GlobalVariables.rabbitColor = "blue";
    }
    public void RabbitOrange()
    {
      GlobalVariables.rabbitColor = "orange";
    }
    public void RabbitPurple()
    {
      GlobalVariables.rabbitColor = "purple";
    }
}
