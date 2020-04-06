using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueTrigger dTrigger;
    public GameObject drawer;
    public GameObject drawer2;
    public GameObject FuseBox;
    public GameObject FuseBox2;
    public GameObject XJCollider;
    public GameObject XJCollider2;
    public GameObject Hole;
    public GameObject Hole2;
    public GameObject Cube;
    public GameObject Cube2;
    public GameObject Elevator;
    public GameObject Elevator2;
    public GameObject statue1;
    public GameObject statue2;
    public GameObject statue3;
    public GameObject StatuesText;
    public GameObject CubeText;
    public GameObject finishedCubeText;
    public GameObject dragonButtonB;
    public GameObject dragonButtonO;
    public GameObject dragonButtonP;
    public GameObject snakeButtonB;
    public GameObject snakeButtonO;
    public GameObject snakeButtonP;
    public GameObject rabbitButtonB;
    public GameObject rabbitButtonO;
    public GameObject rabbitButtonP;
    public GameObject Dragon;
    public GameObject Snake;
    public GameObject Rabbit;
    public GameObject Dragon2;
    public GameObject Snake2;
    public GameObject Rabbit2;

    //level3
    public GameObject Monitor1;
    public GameObject Monitor2;



    void Start()
    {
      Debug.Log("Number of Items Found: " + GlobalVariables.itemsFound);
      Debug.Log("Number of People Talked To: " + GlobalVariables.numberOfPeopleTalkedTo);
      if (SceneManager.GetActiveScene().name == "Infirmary")
      {
        drawer2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        FuseBox2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Dragon.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Snake.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Rabbit.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Dragon2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Snake2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Rabbit2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        dragonButtonB.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        dragonButtonO.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        dragonButtonP.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        snakeButtonB.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        snakeButtonO.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        snakeButtonP.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        rabbitButtonB.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        rabbitButtonO.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        rabbitButtonP.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        XJCollider2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Elevator2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Elevator.SetActive(true);
      }
      if (SceneManager.GetActiveScene().name == "Lounge")
      {
        Cube2.SetActive(false);
      }
      if (SceneManager.GetActiveScene().name == "BroadcastingRoom")
      {
        Monitor2.SetActive(false);
      }

    }

    // Update is called once per frame
    void Update()
    {
      ToNewArea();
      Scene currentScene = SceneManager.GetActiveScene();

      //constantly updates the global variables with positions for the character in specific scenes
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
      if (currentScene.name == "Infirmary")
      {
        GlobalVariables.characterPositionInfirmary = GameObject.Find ("Character").transform.position;
      }
      if (currentScene.name == "Lounge")
      {
        GlobalVariables.characterPositionLounge = GameObject.Find ("Character").transform.position;
      }



      GlobalVariables.sceneNameSaver = currentScene.name;



      //level2
      if (currentScene.name == "Lounge" && GlobalVariables.switchingFuseColliders == true)
      {
        FuseBox.SetActive(false);
        FuseBox2.SetActive(true);
      }
      if (currentScene.name == "Lounge" && GlobalVariables.switchingXJColliders == true)
      {
        XJCollider.SetActive(false);
        XJCollider2.SetActive(true);
      }
      if (currentScene.name == "Infirmary" && GlobalVariables.switchingHoleColliders == true)
      {
        Hole.SetActive(false);
        Hole2.SetActive(true);
      }
      if (currentScene.name == "Infirmary" && GlobalVariables.switchingDrawerColliders == true)
      {
        drawer.SetActive(false);
        drawer2.SetActive(true);
      }
      if (currentScene.name == "Lounge" && GlobalVariables.powerOn == true)
      {
        Dragon.SetActive(true);
        Snake.SetActive(true);
        Rabbit.SetActive(true);
      }
      if (currentScene.name == "Lounge" && GlobalVariables.hasCube == true)
      {
        Cube.SetActive(false);
        Cube2.SetActive(true);
      }

      if (GlobalVariables.inMYCollider2 == true && Input.GetKeyDown("space"))
      {
        GlobalVariables.hasBobbyPin = true;
        GlobalVariables.switchingDrawerColliders = true;
      }
      if (GlobalVariables.inDrawer2Collider == true && Input.GetKeyDown("space"))
      {
        GlobalVariables.hasMagnet = true;
        GlobalVariables.hasMedReport = true;
        GlobalVariables.switchingXJColliders = true;
      }
      if (GlobalVariables.inXJCollider2 == true && Input.GetKeyDown("space"))
      {
        GlobalVariables.switchingHoleColliders = true;
      }
      if (GlobalVariables.inHoleCollider2 == true && Input.GetKeyDown("space"))
      {
        GlobalVariables.hasFuse = true;
        GlobalVariables.switchingFuseColliders = true;
      }

      if (GlobalVariables.inFuse2Collider == true && Input.GetKeyDown("space") && GlobalVariables.displayedStatuesText == false)
      {
        GlobalVariables.powerOn = true;
        //move to after slide puzzle
        StatuesText.GetComponent<DialogueTrigger>().TriggerDialogue();
        GlobalVariables.displayedStatuesText = false;
      }

      if (GlobalVariables.inYZCollider2 == true && Input.GetKeyDown("space"))
      {
        GlobalVariables.talkedYZ2 = true;
      }
      if (currentScene.name == "Lounge" && GlobalVariables.powerOn == true)
      {
        Dragon.SetActive(true);
        Snake.SetActive(true);
        Rabbit.SetActive(true);
      }
      if (currentScene.name == "Lounge" && GlobalVariables.talkedYZ2 == true && GlobalVariables.hasMedReport == true && GlobalVariables.powerOn == true)
      {
        //GlobalVariables.level2CanButton = true;
        Dragon.SetActive(false);
        Dragon2.SetActive(true);
        Snake.SetActive(false);
        Snake2.SetActive(true);
        Rabbit.SetActive(false);
        Rabbit2.SetActive(true);
      }

      ////////////Temporary
      ///////////
      //if (GlobalVariables.hasFuse)
      //{
      //  GlobalVariables.powerOn = true;
      //}
      ///////////
      ///////////



      if (GlobalVariables.inDragonCollider2 == true && Input.GetKeyDown("space"))
      {
        dragonButtonB.SetActive(true);
        dragonButtonO.SetActive(true);
        dragonButtonP.SetActive(true);
      }
      if (GlobalVariables.inSnakeCollider2 == true && Input.GetKeyDown("space"))
      {
        snakeButtonB.SetActive(true);
        snakeButtonO.SetActive(true);
        snakeButtonP.SetActive(true);
      }
      if (GlobalVariables.inRabbitCollider2 == true && Input.GetKeyDown("space"))
      {
        rabbitButtonB.SetActive(true);
        rabbitButtonO.SetActive(true);
        rabbitButtonP.SetActive(true);
      }

      if (GlobalVariables.dragonColor == "blue" && GlobalVariables.snakeColor == "purple" && GlobalVariables.rabbitColor == "blue" && GlobalVariables.displayedCubeText == false)
      {
        CubeText.GetComponent<DialogueTrigger>().TriggerDialogue();
        GlobalVariables.displayedCubeText = true;
        GlobalVariables.hasCube = true;
      }

      if (GlobalVariables.finishedBlock == true && currentScene.name == "Lounge")
      {
        finishedCubeText.GetComponent<DialogueTrigger>().TriggerDialogue();
        GlobalVariables.finishedBlock = false;
        GlobalVariables.hasWire = true;
      }
      if (GlobalVariables.hasWire == true && currentScene.name == "Lounge")
      {
        Elevator.SetActive(false);
        Elevator2.SetActive(true);
      }


      //level3
      if (GlobalVariables.inNoteTextCollider == true)
      {
        if (Input.GetKeyDown("e"))
        {
          SceneManager.LoadScene("NoteText");
        }
      }
      if (GlobalVariables.inPhotoCollider == true)
      {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          Monitor1.SetActive(false);
          Monitor2.SetActive(true);
        }
      }
      if (GlobalVariables.inMonitor2Collider == true)
      {
        if (Input.GetKeyDown("e"))
        {
          SceneManager.LoadScene("Monitor");
        }
      }






      //'e' is interact key
      if (Input.GetKeyDown("e"))
      {
          print("E key was pressed");
          Debug.Log(GlobalVariables.characterPosition1);
          Debug.Log(GlobalVariables.characterPosition2);

          //checking if in collider and haven't pressed 'e' with it before;
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
          if (GlobalVariables.inKeycardItemCollider == true && GlobalVariables.foundKeycard == false)
          {

          }
      }

      //if (Input.GetKeyDown("n"))
      //{
      //    print("N key was pressed");
      //    SceneManager.LoadScene("NotebookHints");
      //}
    }




    //prints when entering a collider
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
          GlobalVariables.noteShaoTing = true;
        }
        if (other.name == "MYCollider")
        {
          Debug.Log("Colliding with Ying");
          GlobalVariables.inMYCollider = true;
          GlobalVariables.noteMei = true;
        }
        if (other.name == "MYCollider2")
        {
          Debug.Log("Colliding with Ying2");
          GlobalVariables.inMYCollider2 = true;
          GlobalVariables.noteMei2 = true;
        }
        if (other.name == "SRCollider")
        {
          Debug.Log("Colliding with SuRong");
          GlobalVariables.inSRCollider = true;
          GlobalVariables.noteSuRong = true;
          if (SceneManager.GetActiveScene().name == "Lounge")
          {
            GlobalVariables.noteSuRong2 = true;
          }
        }
        if (other.name == "YRCollider")
        {
          Debug.Log("Colliding with YongRuan");
          GlobalVariables.inYRCollider = true;
          GlobalVariables.noteYongRuan = true;
          if (SceneManager.GetActiveScene().name == "Infirmary")
          {
            GlobalVariables.noteYongRuan2 = true;
          }
        }
        if (other.name == "YZCollider")
        {
          Debug.Log("Colliding with YiZheng");
          GlobalVariables.inYZCollider = true;
          GlobalVariables.noteYiZheng = true;
        }
        if (other.name == "YZCollider2")
        {
          Debug.Log("Colliding with YiZheng2");
          GlobalVariables.inYZCollider2 = true;
          if (SceneManager.GetActiveScene().name == "Lounge")
          {
            GlobalVariables.noteYiZheng2 = true;
          }
        }
        if (other.name == "PBCollider")
        {
          Debug.Log("Colliding with PinBi");
          GlobalVariables.inPBCollider = true;
          GlobalVariables.notePinBi = true;
          if (SceneManager.GetActiveScene().name == "Lounge")
          {
            GlobalVariables.notePinBi2 = true;
          }
        }
        if (other.name == "XJCollider")
        {
          Debug.Log("Colliding with XiaoJing");
          GlobalVariables.inXJCollider = true;
          GlobalVariables.noteXiaoJing = true;
          if (SceneManager.GetActiveScene().name == "Lounge")
          {
            GlobalVariables.noteXiaoJing2 = true;
          }
        }
        if (other.name == "XJCollider2")
        {
          Debug.Log("Colliding with XiaoJing2");
          GlobalVariables.inXJCollider2 = true;
          if (SceneManager.GetActiveScene().name == "Lounge")
          {
            GlobalVariables.noteXiaoJing2 = true;
          }
        }
        if (other.name == "JHCollider")
        {
          Debug.Log("Colliding with JingHui");
          GlobalVariables.inJHCollider = true;
          GlobalVariables.noteMinKai = true;
        }
        if (other.name == "MKCollider")
        {
          Debug.Log("Colliding with JingHui");
          GlobalVariables.noteMinKai2 = true;
        }
        if (other.name == "YHCollider")
        {
          Debug.Log("Colliding with YingHei");
          GlobalVariables.inYHCollider = true;
          GlobalVariables.noteYingHei = true;
        }
        if (other.name == "Drawer")
        {
          Debug.Log("Colliding with Drawer");
          GlobalVariables.inDrawerCollider = true;
        }
        if (other.name == "Drawer2")
        {
          Debug.Log("Colliding with Drawer2");
          GlobalVariables.inDrawer2Collider = true;
        }
        if (other.name == "FuseBox")
        {
          Debug.Log("Colliding with Fuse");
          GlobalVariables.inFuseCollider = true;
        }
        if (other.name == "FuseBox2")
        {
          Debug.Log("Colliding with Fuse2");
          GlobalVariables.inFuse2Collider = true;
        }
        if (other.name == "HoleInGround")
        {
          Debug.Log("Colliding with Hole");
          GlobalVariables.inHoleCollider = true;
        }
        if (other.name == "HoleInGround2")
        {
          Debug.Log("Colliding with Hole2");
          GlobalVariables.inHoleCollider2 = true;
        }
        if (other.name == "Dragon2")
        {
          Debug.Log("Colliding with Dragon");
          GlobalVariables.inDragonCollider2 = true;
        }
        if (other.name == "Snake2")
        {
          Debug.Log("Colliding with Snake");
          GlobalVariables.inSnakeCollider2 = true;
        }
        if (other.name == "Rabbit2")
        {
          Debug.Log("Colliding with Rabbit");
          GlobalVariables.inRabbitCollider2 = true;
        }
        if (other.name == "NoteCollider")
        {
          Debug.Log("Colliding with Note: Level3");
          GlobalVariables.inNoteTextCollider = true;
        }
        if (other.name == "PhotoCollider")
        {
          Debug.Log("Colliding with Photo: Level3");
          GlobalVariables.inPhotoCollider = true;
        }
        if (other.name == "Monitors2")
        {
          Debug.Log("Colliding with Monitor2");
          GlobalVariables.inMonitor2Collider = true;
        }

    }



    //states when leaving a collider
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "ComputerColliders")
        {
          Debug.Log("Not Colliding with Computer Anymore");
        }
        if (other.name == "EmailCollider")
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
        if (other.name == "MYCollider2")
        {
          Debug.Log("Colliding with Ying2");
          GlobalVariables.inMYCollider2 = false;
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
        if (other.name == "YZCollider2")
        {
          Debug.Log("Colliding with YiZheng2");
          GlobalVariables.inYZCollider2 = false;
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
        if (other.name == "XJCollider2")
        {
          Debug.Log("Colliding with XiaoJing2");
          GlobalVariables.inXJCollider2 = false;
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
        if (other.name == "Drawer")
        {
          Debug.Log("Not Colliding with Drawer");
          GlobalVariables.inDrawerCollider = false;
        }
        if (other.name == "Drawer2")
        {
          Debug.Log("Colliding with Drawer2");
          GlobalVariables.inDrawer2Collider = false;
        }
        if (other.name == "FuseBox")
        {
          Debug.Log("Not Colliding with Fuse");
          GlobalVariables.inFuseCollider = false;
        }
        if (other.name == "FuseBox2")
        {
          Debug.Log("Colliding with Fuse2");
          GlobalVariables.inFuse2Collider = false;
        }
        if (other.name == "HoleInGround")
        {
          Debug.Log("Not Colliding with Hole");
          GlobalVariables.inHoleCollider = false;
        }
        if (other.name == "HoleInGround2")
        {
          Debug.Log("Not Colliding with Hole2");
          GlobalVariables.inHoleCollider2 = false;
        }
        if (other.name == "Dragon2")
        {
          Debug.Log("Not Colliding with Dragon");
          GlobalVariables.inDragonCollider2 = false;
        }
        if (other.name == "Snake2")
        {
          Debug.Log("Not Colliding with Snake");
          GlobalVariables.inSnakeCollider2 = false;
        }
        if (other.name == "Rabbit2")
        {
          Debug.Log("Not Colliding with Rabbit");
          GlobalVariables.inRabbitCollider2 = false;
        }
        if (other.name == "NoteCollider")
        {
          Debug.Log("Not Colliding with Note: Level3");
          GlobalVariables.inNoteTextCollider = false;

        }
        if (other.name == "PhotoCollider")
        {
          Debug.Log("Not Colliding with Photo: Level3");
          GlobalVariables.inPhotoCollider = false;

        }
        if (other.name == "Monitors2")
        {
          Debug.Log("Not Colliding with Monitor2");
          GlobalVariables.inMonitor2Collider = false;
        }
    }

    //loads a new scene based on collision with colliders
    void ToNewArea()
    {
      if (Input.GetKeyDown("e") && GlobalVariables.inElevatorCollider1 == true)
      {
        Debug.Log("Moving to Floor 2");
        SceneManager.LoadScene("Floor2Final");
        GlobalVariables.inElevatorCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inElevatorCollider2 == true)
      {
        Debug.Log("Moving to Floor 1");
        SceneManager.LoadScene("Floor1Final");
        GlobalVariables.inElevatorCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMeetingRoomCollider1 == true)
      {
        Debug.Log("Moving to Meeting RoomFloor 1");
        SceneManager.LoadScene("MeetingRoom1");
        GlobalVariables.inMeetingRoomCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMaleBathroomCollider1 == true)
      {
        Debug.Log("Moving to Male BathroomFloor 1");
        SceneManager.LoadScene("MaleBathroom1");
        GlobalVariables.inMaleBathroomCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inFemaleBathroomCollider1 == true)
      {
        Debug.Log("Moving to Female Bathroom Floor 1");
        SceneManager.LoadScene("FemaleBathroom1");
        GlobalVariables.inFemaleBathroomCollider1 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMeetingRoomCollider2 == true)
      {
        Debug.Log("Moving to Meeting RoomFloor 2");
        SceneManager.LoadScene("MeetingRoom2");
        GlobalVariables.inMeetingRoomCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inMaleBathroomCollider2 == true)
      {
        Debug.Log("Moving to Male BathroomFloor 2");
        SceneManager.LoadScene("MaleBathroom2");
        GlobalVariables.inMaleBathroomCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inFemaleBathroomCollider2 == true)
      {
        Debug.Log("Moving to Female Bathroom Floor 2");
        SceneManager.LoadScene("FemaleBathroom2");
        GlobalVariables.inFemaleBathroomCollider2 = false;
      }
      if (Input.GetKeyDown("e") && GlobalVariables.inKeycardCollider == true)
      {
        if (GlobalVariables.itemsFound == 5 && GlobalVariables.numberOfPeopleTalkedTo == 9)
        {
          Debug.Log("Starting Keycard Guesser");
          SceneManager.LoadScene("FinalKeycardGuesser");
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

      //changes variables after talking to players
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inSTCollider == true)
      {
        Debug.Log("Moving to ST Text");
        if (GlobalVariables.talkedST == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedST = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inMYCollider == true)
      {
        Debug.Log("Moving to MY Text");
        if (GlobalVariables.talkedMY == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedMY = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inSRCollider == true)
      {
        Debug.Log("Moving to SR Text");
        if (GlobalVariables.talkedSR == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedSR = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inYZCollider == true)
      {
        Debug.Log("Moving to YZ Text");
        if (GlobalVariables.talkedYZ == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedYZ = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inPBCollider == true)
      {
        Debug.Log("Moving to PB Text");
        if (GlobalVariables.talkedPB == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedPB = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inXJCollider == true)
      {
        Debug.Log("Moving to XJ Text");
        if (GlobalVariables.talkedXJ == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.itemsFound++;
          GlobalVariables.talkedXJ = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inYRCollider == true)
      {
        Debug.Log("Moving to YR Text");
        if (GlobalVariables.talkedYR == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedYR = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inJHCollider == true)
      {
        Debug.Log("Moving to JH Text");
        if (GlobalVariables.talkedJH == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.itemsFound++;
          GlobalVariables.talkedJH = true;
        }
      }
      if (Input.GetKeyDown(KeyCode.Space) && GlobalVariables.inYHCollider == true)
      {
        Debug.Log("Moving to YH Text");
        if (GlobalVariables.talkedYH == false)
        {
          GlobalVariables.numberOfPeopleTalkedTo++;
          GlobalVariables.talkedYH = true;
        }
      }
    }

}
