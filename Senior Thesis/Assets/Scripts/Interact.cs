using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GlobalVariables.itemsFound = 0.0f;
      Debug.Log("Number of Items Found: " + GlobalVariables.itemsFound);
      GlobalVariables.inEmailCollider = false;
      GlobalVariables.foundEmail = false;
    }

    // Update is called once per frame
    void Update()
    {
      ToNewArea();
      Scene currentScene = SceneManager.GetActiveScene();

      if (currentScene.name == "Floor1Final")
      {
        GlobalVariables.characterPosition1 = GameObject.Find ("Character").transform.position;
      }

      if (currentScene.name == "Floor2Final")
      {
        GlobalVariables.characterPosition2 = GameObject.Find ("Character").transform.position;
      }

      GlobalVariables.sceneNameSaver = currentScene.name;



      //'e' is interact key
      if (Input.GetKeyDown("e"))
      {
          print("E key was pressed");
          Debug.Log(GlobalVariables.characterPosition1);
          Debug.Log(GlobalVariables.characterPosition2);

          //checking if in collider and haven't pressed 'e' with it before;
          //eventually will have checks for all key items to interact with;
          //also will have a similar check that checks if itemsFound variable
          ////is at proper value to allow completion of level when in that collider;
          if (GlobalVariables.inEmailCollider == true && GlobalVariables.foundEmail == false)
          {
            Debug.Log("E key was pressed in ComputerCollider");
            GlobalVariables.itemsFound++;
            GlobalVariables.foundEmail = true;
            Debug.Log("Number of Items Found: " + GlobalVariables.itemsFound);
          }
      }

      if (Input.GetKeyDown("n"))
      {
          print("N key was pressed");
          SceneManager.LoadScene("NotebookHints");
      }
    }



    //checks if in a collider or not;
    //eventually will have name checks for all key items to interact with;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "ComputerColliders")
        {
          Debug.Log("Colliding with Off Computer");
        }
        if (other.name == "EmailCollider")
        {
          Debug.Log("Colliding with Email Computer");
          GlobalVariables.inEmailCollider = true;
        }
        if (other.name == "ToFloor2")
        {
          Debug.Log("Colliding with Elevator Floor 1");
          GlobalVariables.inElevatorCollider1 = true;
        }
        if (other.name == "ToFloor1")
        {
          Debug.Log("Colliding with Elevator Floor 2");
          GlobalVariables.inElevatorCollider2 = true;
        }
        if (other.name == "ToMeetingRoom1")
        {
          Debug.Log("Colliding with Meeting Room Floor 1");
          GlobalVariables.inMeetingRoomCollider1 = true;
        }
        if (other.name == "ToMaleBathroom1")
        {
          Debug.Log("Colliding with Male Bathroom Floor 1");
          GlobalVariables.inMaleBathroomCollider1 = true;
        }
        if (other.name == "ToFemaleBathroom1")
        {
          Debug.Log("Colliding with Female Bathroom Floor 1");
          GlobalVariables.inFemaleBathroomCollider1 = true;
        }
        if (other.name == "ToMeetingRoom2")
        {
          Debug.Log("Colliding with Meeting Room Floor 2");
          GlobalVariables.inMeetingRoomCollider2 = true;
        }
        if (other.name == "ToMaleBathroom2")
        {
          Debug.Log("Colliding with Male Bathroom Floor 2");
          GlobalVariables.inMaleBathroomCollider2 = true;
        }
        if (other.name == "ToFemaleBathroom2")
        {
          Debug.Log("Colliding with Female Bathroom Floor 2");
          GlobalVariables.inFemaleBathroomCollider2 = true;
        }
        if (other.name == "KeycardTrigger")
        {
          Debug.Log("Colliding with Keycard Trigger");
          GlobalVariables.inKeycardCollider = true;
        }
        if (other.name == "FromMeetingRoom1")
        {
          Debug.Log("Leaving Meeting Room Floor 1");
          SceneManager.LoadScene("Floor1Final");
        }
        if (other.name == "FromMaleBathroom1")
        {
          Debug.Log("Leaving Male Bathroom Floor 1");
          SceneManager.LoadScene("Floor1Final");
        }
        if (other.name == "FromFemaleBathroom1")
        {
          Debug.Log("Leaving Female Bathroom Floor 1");
          SceneManager.LoadScene("Floor1Final");
        }
        if (other.name == "FromMeetingRoom2")
        {
          Debug.Log("Leaving Meeting Room Floor 2");
          SceneManager.LoadScene("Floor2Final");
        }
        if (other.name == "FromMaleBathroom2")
        {
          Debug.Log("Leaving Male Bathroom Floor 2");
          SceneManager.LoadScene("Floor2Final");
        }
        if (other.name == "FromFemaleBathroom2")
        {
          Debug.Log("Leaving Female Bathroom Floor 2");
          SceneManager.LoadScene("Floor2Final");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "ComputerColliders")
        {
          Debug.Log("Not Colliding with Computer Anymore");
        }
        if (other.name == "EmailCollider")// && other.isTrigger == true)
        {
          Debug.Log("Not Colliding with Email Computer");
          GlobalVariables.inEmailCollider = false;
        }
        if (other.name == "ToFloor2")
        {
          Debug.Log("Not Colliding with Elevator Floor 1");
          GlobalVariables.inElevatorCollider1 = false;
        }
        if (other.name == "ToFloor1")
        {
          Debug.Log("Not Colliding with Elevator Floor 2");
          GlobalVariables.inElevatorCollider2 = false;
        }
        if (other.name == "ToMeetingRoom1")
        {
          Debug.Log("Not Colliding with Meeting Room Floor 1");
          GlobalVariables.inMeetingRoomCollider1 = false;
        }
        if (other.name == "ToMaleBathroom1")
        {
          Debug.Log("Not Colliding with Male Bathroom Floor 1");
          GlobalVariables.inMaleBathroomCollider1 = false;
        }
        if (other.name == "ToFemaleBathroom1")
        {
          Debug.Log("Not Colliding with Female Bathroom Floor 1");
          GlobalVariables.inFemaleBathroomCollider1 = false;
        }
        if (other.name == "ToMeetingRoom2")
        {
          Debug.Log("Not Colliding with Meeting Room Floor 2");
          GlobalVariables.inMeetingRoomCollider2 = false;
        }
        if (other.name == "ToMaleBathroom2")
        {
          Debug.Log("Not Colliding with Male Bathroom Floor 2");
          GlobalVariables.inMaleBathroomCollider2 = false;
        }
        if (other.name == "ToFemaleBathroom2")
        {
          Debug.Log("Not Colliding with Female Bathroom Floor 2");
          GlobalVariables.inFemaleBathroomCollider2 = false;
        }
        if (other.name == "KeycardTrigger")
        {
          Debug.Log("Not Colliding with Keycard Trigger");
          GlobalVariables.inKeycardCollider = false;
        }
    }


    void ToNewArea()
    {
      if (Input.GetKeyDown("e") && GlobalVariables.inElevatorCollider1 == true)
      {
        Debug.Log("Moving to Floor 2");
        //GlobalVariables.characterPosition1 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("Floor2Final");
        GlobalVariables.inElevatorCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inElevatorCollider2 == true)
      {
        Debug.Log("Moving to Floor 1");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("Floor1Final");
        GlobalVariables.inElevatorCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMeetingRoomCollider1 == true)
      {
        Debug.Log("Moving to Meeting RoomFloor 1");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("MeetingRoom1");
        GlobalVariables.inMeetingRoomCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMaleBathroomCollider1 == true)
      {
        Debug.Log("Moving to Male BathroomFloor 1");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("MaleBathroom1");
        GlobalVariables.inMaleBathroomCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inFemaleBathroomCollider1 == true)
      {
        Debug.Log("Moving to Female Bathroom Floor 1");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("FemaleBathroom1");
        GlobalVariables.inFemaleBathroomCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMeetingRoomCollider2 == true)
      {
        Debug.Log("Moving to Meeting RoomFloor 2");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("MeetingRoom2");
        GlobalVariables.inMeetingRoomCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMaleBathroomCollider2 == true)
      {
        Debug.Log("Moving to Male BathroomFloor 2");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("MaleBathroom2");
        GlobalVariables.inMaleBathroomCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inFemaleBathroomCollider2 == true)
      {
        Debug.Log("Moving to Female Bathroom Floor 2");
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("FemaleBathroom2");
        GlobalVariables.inFemaleBathroomCollider2 = false;
      }
    }

}
