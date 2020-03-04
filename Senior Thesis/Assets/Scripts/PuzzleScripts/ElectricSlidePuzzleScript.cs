﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectricSlidePuzzleScript : MonoBehaviour
{
      /*     public GameObject b1;
           public GameObject b2;
           public GameObject b3;
           public GameObject b4;
           public GameObject b5;
           public GameObject b6;
           public GameObject b7;
           public GameObject b8;
           public GameObject b9;
           public GameObject b10;
           public GameObject b11;
           public GameObject b12;
           public GameObject b13;
           public GameObject b14;
           public GameObject b15;
           public GameObject b16;
           public GameObject b17;
           public GameObject b18;
           public GameObject b19;
           public GameObject b20;
           public GameObject fodder;
           public GameObject NullObject = null;
           public GameObject temp = null;
           // Start is called before the first frame update
           void Start()
           {

           }

           // Update is called once per frame
           void Update()
           {
               IsFinished();
           }


           //Rotation is on z and is 0,-90,-180,90
           public void IsFinished()
           {
               //check all the transforms to see if they are in the correct places. or maybe brainstorm an easier option
               if (b1.gameObject.transform.rotation.z == -90.00001 && b2.gameObject.transform.rotation.z == -180) //&& b3.gameObject.transform.rotation.z == 0 && b5.gameObject.transform.rotation.z == 0 && b6.gameObject.transform.rotation.z == 0 && b8.gameObject.transform.rotation.z == 0 && b9.gameObject.transform.rotation.z == 0 && b10.gameObject.transform.rotation.z == 0 && b11.gameObject.transform.rotation.z == 0 && b12.gameObject.transform.rotation.z == 0 && b13.gameObject.transform.rotation.z == 0 && b14.gameObject.transform.rotation.z == 0 && b15.gameObject.transform.rotation.z == 0 && b16.gameObject.transform.rotation.z == 0 && b17.gameObject.transform.rotation.z == 0 && b18.gameObject.transform.rotation.z == 0 && b19.gameObject.transform.rotation.z == 0 && b20.gameObject.transform.rotation.z == 0)
               {
                   b3.transform.Rotate(Vector3.forward * -90);
                   //Load back scene since it is finished.
                   //SceneManager.LoadScene(0);
                   Application.Quit();
               }
           }


           public void OnClick(GameObject clicked)
           {
               //how the buttons interact with just the push of the button, moveing the transforms to a temp variable and then moving them
               //here the clicked button goes to null until there are 2 buttons left.
               if(temp == null)
               {
                   fodder = clicked;
                   temp = fodder;
                   temp.transform.position = fodder.transform.position;
                   fodder.transform.position = fodder.transform.position;
                   fodder = null;
                   DontDestroyOnLoad(temp);
               }

               //else statement works as intended with the transform.
               else
               {
                   clicked.transform.position = temp.transform.position;
                   temp = NullObject;
                   DontDestroyOnLoad(temp);
               }
           }

           public void Rotate(GameObject obj1)
           {
               obj1.transform.Rotate(Vector3.forward * -90);
               if (b1.gameObject.transform.rotation.z == -90.00001 && b2.gameObject.transform.rotation.z == -180) //&& b3.gameObject.transform.rotation.z == 0 && b5.gameObject.transform.rotation.z == 0 && b6.gameObject.transform.rotation.z == 0 && b8.gameObject.transform.rotation.z == 0 && b9.gameObject.transform.rotation.z == 0 && b10.gameObject.transform.rotation.z == 0 && b11.gameObject.transform.rotation.z == 0 && b12.gameObject.transform.rotation.z == 0 && b13.gameObject.transform.rotation.z == 0 && b14.gameObject.transform.rotation.z == 0 && b15.gameObject.transform.rotation.z == 0 && b16.gameObject.transform.rotation.z == 0 && b17.gameObject.transform.rotation.z == 0 && b18.gameObject.transform.rotation.z == 0 && b19.gameObject.transform.rotation.z == 0 && b20.gameObject.transform.rotation.z == 0)
               {
                   b3.transform.Rotate(Vector3.forward * -90);
                   //Load back scene since it is finished.
                   //SceneManager.LoadScene(0);
                   Application.Quit();
               }
           }

           /*public bool CheckMod0(GameObject checked1)
           {
               if (checked1.transform.rotation.y % 360 == 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }

           public bool CheckMod90(GameObject checked1)
           {
               if (checked1.transform.rotation.y % 90 == 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }

           public bool CheckMod180(GameObject checked1)
           {
               if (checked1.transform.rotation.y % 360 == 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }

           public bool CheckMod270(GameObject checked1)
           {
               if (checked1.transform.rotation.y % 360 == 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           */
    [SerializeField]
    private Transform[] lanes;

    public int index;
    public void Update()
    {
    
        //Rotation is on z and is 0,-90,-180,90
        if (lanes[0].gameObject.transform.rotation.z == -90.00001 && lanes[1].gameObject.transform.rotation.z == 0.0 && lanes[2].gameObject.transform.rotation.z == -90.00001 && lanes[3].gameObject.transform.rotation.z == 0.0 && lanes[4].gameObject.transform.rotation.z == 90.00001 && lanes[5].gameObject.transform.rotation.z == -180.0 && lanes[6].gameObject.transform.rotation.z == -90.00001 && lanes[7].gameObject.transform.rotation.z == 0.0 && lanes[8].gameObject.transform.rotation.z == 0.0 && lanes[9].gameObject.transform.rotation.z == -90.00001 && lanes[10].gameObject.transform.rotation.z == 90.00001 && lanes[11].gameObject.transform.rotation.z == 90.00001 && lanes[12].gameObject.transform.rotation.z == -90.00001 && lanes[13].gameObject.transform.rotation.z == 0.0 && lanes[14].gameObject.transform.rotation.z == -180.0 && lanes[15].gameObject.transform.rotation.z == 0.0 && lanes[16].gameObject.transform.rotation.z == -180.0 && lanes[17].gameObject.transform.rotation.z == 90.00001 && lanes[18].gameObject.transform.rotation.z == 0.0)
        {
            
            SceneManager.LoadScene(index);
             
        }

    }

    private void OnMouseDown()
    {
        //once build the check to see if finished use an if statement.
            transform.Rotate(0f, 0f, 90f);
    }
}
