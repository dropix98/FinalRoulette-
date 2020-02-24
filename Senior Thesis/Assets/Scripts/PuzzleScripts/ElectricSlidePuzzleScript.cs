using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricSlidePuzzleScript : MonoBehaviour
{

    public GameObject b1;
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

    public void IsFinished()
    {
        //check all the transforms to see if they are in the correct places. or maybe brainstorm an easier option
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
    }
}
