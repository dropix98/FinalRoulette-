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
        if (other.name == "CheckEmailCollider")// && other.isTrigger == true)
        {
          Debug.Log("Colliding with Computer");
          GlobalVariables.inEmailCollider = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "CheckEmailCollider")// && other.isTrigger == true)
        {
          Debug.Log("Not Colliding with Computer Anymore");
          GlobalVariables.inEmailCollider = false;
        }
    }
  }
