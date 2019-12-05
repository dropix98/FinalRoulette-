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
      GlobalVariables.inWallCollider = false;
      GlobalVariables.foundWallColliderItem = false;
    }

    // Update is called once per frame
    void Update()
    {
      //'e' is interact key
      if (Input.GetKeyDown("e"))
      {
          print("E key was pressed");

          //checking if in collider and haven't pressed 'e' with it before;
          //eventually will have checks for all key items to interact with;
          //also will have a similar check that checks if itemsFound variable
          ////is at proper value to allow completion of level when in that collider;
          if (GlobalVariables.inWallCollider == true && GlobalVariables.foundWallColliderItem == false)
          {
            Debug.Log("E key was pressed in wallCollider");
            GlobalVariables.itemsFound++;
            GlobalVariables.foundWallColliderItem = true;
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
        if (other.name == "OfficeWalls 1")
        {
          Debug.Log("Colliding with Wall");
          GlobalVariables.inWallCollider = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "OfficeWalls 1")
        {
          Debug.Log("Not Colliding with Wall Anymore");
          GlobalVariables.inWallCollider = false;
        }
    }
  }
