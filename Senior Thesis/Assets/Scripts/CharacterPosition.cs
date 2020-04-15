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

        if (currentScene.name == "Floor1Final")
        {
          transform.position = GlobalVariables.characterPosition1;
        }
        if (currentScene.name == "Floor2Final")
        {
          transform.position = GlobalVariables.characterPosition2;
        }
        if (currentScene.name == "MeetingRoom1")
        {
          transform.position = GlobalVariables.characterPosition1meeting;
        }

        if (currentScene.name == "MaleBathroom1")
        {
          transform.position = GlobalVariables.characterPosition1mbath;
        }

        if (currentScene.name == "FemaleBathroom1")
        {
          transform.position = GlobalVariables.characterPosition1fbath;
        }

        if (currentScene.name == "MeetingRoom2")
        {
          transform.position = GlobalVariables.characterPosition2meeting;
        }

        if (currentScene.name == "MaleBathroom2")
        {
          transform.position = GlobalVariables.characterPosition2mbath;
        }

        if (currentScene.name == "FemaleBathroom2")
        {
          transform.position = GlobalVariables.characterPosition2fbath = GameObject.Find ("Character").transform.position;
        }

        if (currentScene.name == "Lounge")
        {
          transform.position = GlobalVariables.characterPositionLounge;
        }

        if (currentScene.name == "Infirmary")
        {
          transform.position = GlobalVariables.characterPositionInfirmary;
        }

        if (currentScene.name == "BroadcastingRoom")
        {
            transform.position = GlobalVariables.characterPositionBroadcast;
        }

        if (currentScene.name == "MachineRoom")
        {
            transform.position = GlobalVariables.characterPositionMachineRoom;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
