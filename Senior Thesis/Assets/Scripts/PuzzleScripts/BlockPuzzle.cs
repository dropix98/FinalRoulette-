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
      
    }

    void OnMouseDown()
    {
      objectName = this.gameObject.name;
      Debug.Log(objectName);
    }
}
