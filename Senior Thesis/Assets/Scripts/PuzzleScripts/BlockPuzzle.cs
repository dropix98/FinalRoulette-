using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzle : MonoBehaviour
{
    string objectName = "";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //if ()

      if (Input.GetKeyDown("d"))
        {
            print("Turn Right key was pressed");
        }
      if (Input.GetKeyDown("a"))
        {
            print("Turn Left key was pressed");
        }
    }

    void OnMouseDown()
    {
      objectName = this.gameObject.name;
      Debug.Log(objectName);
    }
}
