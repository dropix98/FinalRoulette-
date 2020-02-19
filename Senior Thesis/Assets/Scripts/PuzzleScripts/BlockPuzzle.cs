using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzle : MonoBehaviour
{
    string objectName = "";
    /*public gameObject block1;
    public gameObject block2;
    public gameObject block3;
    public gameObject block4;*/
    float localRotation;
    //public float RotationSpeed = 2.0f;
    //Vector3 rightturn = new Vector3(0f, 90f, 0f);
    float rotationAmount = 75.000f;
    //private float timer = 0.0f;
    //private float waitTime = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
      localRotation = -1;
    }

    // Update is called once per frame
    void Update()
    {
      if (localRotation != -1)
      {
        //while (timer <= waitTime)// (localRotation == 90 || localRotation == 180 || localRotation == 270 || localRotation == 360)
        //{
          transform.Rotate (new Vector3(0, rotationAmount, 0) * Time.deltaTime);
          //timer += Time.deltaTime;
          //print("timer");
        //}
        if (Input.GetKeyDown("d"))
          {
              print("Turn Right key was pressed");
              transform.Rotate(0, 90.000f, 0);

              //transform.Rotate ( rightturn * ( RotationSpeed * Time.deltaTime ) );
              //objectName.transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime);
          }
        if (Input.GetKeyDown("a"))
          {
              print("Turn Left key was pressed");

          }
       }
    }

    void OnMouseDown()
    {
      localRotation = this.transform.rotation.eulerAngles.y;
      objectName = this.gameObject.name;
      Debug.Log(objectName);
    }
}
