using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzle : MonoBehaviour
{
    string objectName = "";
    float localRotation = -1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (localRotation != -1)
      {

        if (Input.GetKeyDown("d"))
          {
              print("Turn Right key was pressed");
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
