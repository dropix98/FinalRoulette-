using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueTrigger dTrigger; 
    void Start()
    {
      //GlobalVariables.itemsFound = 0;
      Debug.Log("Number of Items Found: " + GlobalVariables.itemsFound);
      Debug.Log("Number of People Talked To: " + GlobalVariables.numberOfPeopleTalkedTo);
      

      /*GlobalVariables.inEmailCollider = false;
      GlobalVariables.inNewsArticleCollider = false;
      GlobalVariables.inKeycardItemCollider = false;
      GlobalVariables.foundEmail = false;
      GlobalVariables.triedKeycardOnDoor = false;
      GlobalVariables.foundNewsArticle = false;
      GlobalVariables.foundJanitorHint = false;
      GlobalVariables.foundSecretaryHint = false;
      GlobalVariables.talkedMY = false;
      GlobalVariables.talkedCS = false;
      GlobalVariables.talkedWY = false;
      GlobalVariables.talkedZX = false;
      GlobalVariables.talkedZYH = false;
      GlobalVariables.talkedWS = false;
      GlobalVariables.talkedZYR = false;
      GlobalVariables.talkedLP = false;
      GlobalVariables.talkedLM = false;*/

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

      if (currentScene.name == "MeetingRoom1")
      {
        GlobalVariables.characterPosition1meeting = GameObject.Find ("Character").transform.position;
      }

      if (currentScene.name == "MaleBathroom1")
      {
        GlobalVariables.characterPosition1mbath = GameObject.Find ("Character").transform.position;
      }

      if (currentScene.name == "FemaleBathroom1")
      {
        GlobalVariables.characterPosition1fbath = GameObject.Find ("Character").transform.position;
      }

      if (currentScene.name == "MeetingRoom2")
      {
        GlobalVariables.characterPosition2meeting = GameObject.Find ("Character").transform.position;
      }

      if (currentScene.name == "MaleBathroom2")
      {
        GlobalVariables.characterPosition2mbath = GameObject.Find ("Character").transform.position;
      }

      if (currentScene.name == "FemaleBathroom2")
      {
        GlobalVariables.characterPosition2fbath = GameObject.Find ("Character").transform.position;
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
            SceneManager.LoadScene("EmailText");
            GlobalVariables.itemsFound++;
            GlobalVariables.foundEmail = true;
            Debug.Log("Number of Items Found: " + GlobalVariables.itemsFound);
          }
          if (GlobalVariables.inNewsArticleCollider == true && GlobalVariables.foundNewsArticle == false)
          {
            Debug.Log("E key was pressed in NewsArticleCollider");
            GlobalVariables.itemsFound++;
            GlobalVariables.foundNewsArticle = true;
            Debug.Log("Number of Items Found: " + GlobalVariables.itemsFound);
          }
          if (GlobalVariables.inKeycardItemCollider == true && GlobalVariables.foundKeycard == false)
          {
            Debug.Log("E key was pressed in keycard collider");
            SceneManager.LoadScene("KeycardText");
            GlobalVariables.itemsFound++;
            GlobalVariables.foundKeycard = true;
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
        if (other.name == "NewsArticleCollider")
        {
          Debug.Log("Colliding with News Article");
          GlobalVariables.inNewsArticleCollider = true;
        }
        if (other.name == "KeycardCollider")
        {
          Debug.Log("Colliding with Keycard Item");
          GlobalVariables.inKeycardItemCollider = true;
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
        if (other.name == "STCollider")
        {
          Debug.Log("Colliding with ShaoTing");
          GlobalVariables.inSTCollider = true;
        }
        if (other.name == "MYCollider")
        {
          Debug.Log("Colliding with Ying");
          GlobalVariables.inMYCollider = true;
        }
        if (other.name == "SRCollider")
        {
          Debug.Log("Colliding with SuRong");
          GlobalVariables.inSRCollider = true;
        }
        if (other.name == "YRCollider")
        {
          Debug.Log("Colliding with YongRuan");
          GlobalVariables.inYRCollider = true;
        }
        if (other.name == "YZCollider")
        {
          Debug.Log("Colliding with YiZheng");
          GlobalVariables.inYZCollider = true;
        }
        if (other.name == "PBCollider")
        {
          Debug.Log("Colliding with PinBi");
          GlobalVariables.inPBCollider = true;
        }
        if (other.name == "XJCollider")
        {
          Debug.Log("Colliding with XiaoJing");
          GlobalVariables.inXJCollider = true;
        }
        if (other.name == "JHCollider")
        {
          Debug.Log("Colliding with JingHui");
          GlobalVariables.inJHCollider = true;
        }
        if (other.name == "YHCollider")
        {
          Debug.Log("Colliding with YingHei");
          GlobalVariables.inYHCollider = true;
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
        if (other.name == "NewsArticleCollider")
        {
          Debug.Log("Not Colliding with News Article");
          GlobalVariables.inNewsArticleCollider = false;
        }
        if (other.name == "KeycardCollider")
        {
          Debug.Log("Not Colliding with Keycard Item");
          GlobalVariables.inKeycardItemCollider = false;
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
        if (other.name == "STCollider")
        {
          Debug.Log("Not Colliding with ShaoTing");
          GlobalVariables.inSTCollider = false;
        }
        if (other.name == "MYCollider")
        {
          Debug.Log("Not Colliding with Ying");
          GlobalVariables.inMYCollider = false;
        }
        if (other.name == "SRCollider")
        {
          Debug.Log("Not Colliding with SuRong");
          GlobalVariables.inSRCollider = false;
        }
        if (other.name == "YRCollider")
        {
          Debug.Log("Not Colliding with YongRuan");
          GlobalVariables.inYRCollider = false;
        }
        if (other.name == "YZCollider")
        {
          Debug.Log("Not Colliding with YiZheng");
          GlobalVariables.inYZCollider = false;
        }
        if (other.name == "PBCollider")
        {
          Debug.Log("Not Colliding with PinBi");
          GlobalVariables.inPBCollider = false;
        }
        if (other.name == "XJCollider")
        {
          Debug.Log("Not Colliding with XiaoJing");
          GlobalVariables.inXJCollider = false;
        }
        if (other.name == "JHCollider")
        {
          Debug.Log("Not Colliding with JingHui");
          GlobalVariables.inJHCollider = false;
        }
        if (other.name == "YHCollider")
        {
          Debug.Log("Not Colliding with YingHei");
          GlobalVariables.inYHCollider = false;
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
      if (Input.GetKeyDown("e") && GlobalVariables.inKeycardCollider == true)
      {
        if (GlobalVariables.itemsFound == 5 && GlobalVariables.numberOfPeopleTalkedTo == 9)
        {
          Debug.Log("Starting Keycard Guesser");
          //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
          SceneManager.LoadScene("FinalKeycardGuesser");
          //GlobalVariables.inFemaleBathroomCollider1 = false;
          //GlobalVariables.inKeycardGuesser = true;
        }
        else if (GlobalVariables.itemsFound == 5)
        {
          SceneManager.LoadScene("Message");
        }
        else if (GlobalVariables.numberOfPeopleTalkedTo == 9)
        {
          SceneManager.LoadScene("Message2");
        }
        else if (GlobalVariables.foundKeycard)
        {
          SceneManager.LoadScene("KeycardText2");
          GlobalVariables.triedKeycardOnDoor = true;
        }

      }


      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inSTCollider == true)
      {
        //Debug.Log("Moving to ST Text");
        //GlobalVariables.talkedWS = true;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        GlobalVariables.inSTCollider = false;
        GlobalVariables.numberOfPeopleTalkedTo++;


        }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inMYCollider == true)
      {
        Debug.Log("Moving to MY Text");
        //GlobalVariables.talkedMY = true;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        GlobalVariables.inMYCollider = false;
        GlobalVariables.numberOfPeopleTalkedTo++;
        SceneManager.LoadScene("YingText");
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inSRCollider == true)
      {
        Debug.Log("Moving to SR Text");
        //GlobalVariables.talkedCS = true;
        GlobalVariables.inSRCollider = false;
        GlobalVariables.numberOfPeopleTalkedTo++;
       //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
       SceneManager.LoadScene("SuRongText");

      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inYZCollider == true)
      {
        Debug.Log("Moving to YZ Text");
        //GlobalVariables.talkedWY = true;
        GlobalVariables.inYZCollider = false;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("YiZhengText");
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inPBCollider == true)
      {
        Debug.Log("Moving to PB Text");
        //GlobalVariables.talkedLP = true;
        GlobalVariables.inPBCollider = false;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("PinBiText");
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inXJCollider == true)
      {
        Debug.Log("Moving to XJ Text");
        //GlobalVariables.talkedZX = true;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);\
        GlobalVariables.itemsFound++;
        GlobalVariables.inXJCollider = false;
        SceneManager.LoadScene("XiaoJingText");
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inYRCollider == true)
      {
        Debug.Log("Moving to YR Text");
        //GlobalVariables.talkedZYR = true;
        GlobalVariables.inYRCollider = false;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("YongRuanText");
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inJHCollider == true)
      {
        Debug.Log("Moving to JH Text");
        //GlobalVariables.talkedLM = true;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        GlobalVariables.itemsFound++;
        GlobalVariables.inJHCollider = false;
        SceneManager.LoadScene("MinKaiText");
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inYHCollider == true)
      {
        Debug.Log("Moving to YH Text");
        //GlobalVariables.talkedZYH = true;
        GlobalVariables.inYHCollider = false;
        //GlobalVariables.characterPosition2 = new Vector3(1, -1, 0);
        SceneManager.LoadScene("YingHeiText");
      }
    }

}
