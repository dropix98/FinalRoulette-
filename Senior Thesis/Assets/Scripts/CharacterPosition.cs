using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "TestScene")
        {
          transform.position = GlobalVariables.characterPosition1;
        }
        //for when there is a second floor
        /*if (sceneName == "SecondFloorScene")
        {
          transform.position = GlobalVariables.characterPosition2;
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
