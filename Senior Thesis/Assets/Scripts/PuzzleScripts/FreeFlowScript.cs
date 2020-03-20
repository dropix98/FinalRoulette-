using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFlowScript : MonoBehaviour
{
    /*

    GameObject temp;
    public Material orange;
    public Material pink;
    public Material darkblue;
    public Material purple;
    public Material green;
    public Material teal;
    public Material yellow;
    public Material lightblue;
    public Material red;
    public Material lilac;

    public Material newMaterial;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown(GameObject go)
    {
        temp = go;

        go.GetComponent<MeshRenderer>().material = newMaterial;
    }

    void Update()
    {
        if (temp == GameObject.Find("Orange1") || temp == GameObject.Find("Orange2"))
        {
            //if stataement to change the material on the game object and to check if the mouse is still down.
            //going to make a temp one in another function that is on click to change the color
            newMaterial = orange;
        }

        if (temp == GameObject.Find("Pink1") || temp == GameObject.Find("Pink2"))
        {
            newMaterial = pink;
        }

        if (temp == GameObject.Find("DarkBlue1") || temp == GameObject.Find("DarkBle2"))
        {
            newMaterial = darkblue;
        }

        if (temp == GameObject.Find("Purple1") || temp == GameObject.Find("Purple2"))
        {
            newMaterial = purple;
        }

        if (temp == GameObject.Find("Green1") || temp == GameObject.Find("Green2"))
        {
            newMaterial = green;
        }

        if (temp == GameObject.Find("Teal1") || temp == GameObject.Find("Teal2"))
        {
            newMaterial = teal;
        }

        if (temp == GameObject.Find("Yellow1") || temp == GameObject.Find("Yellow2"))
        {
            newMaterial = yellow;
        }

        if (temp == GameObject.Find("LightBlue1") || temp == GameObject.Find("LightBlue2"))
        {
            newMaterial = lightblue;
        }

        if (temp == GameObject.Find("Red1") || temp == GameObject.Find("Red2"))
        {
            newMaterial = red;
        }

        if (temp == GameObject.Find("Lilac1") || temp == GameObject.Find("Lilac2"))
        {
            newMaterial = lilac;
        }
    }

    */

    public Material currentMaterial;

    public Material[] materials;
    public GameObject[] gameobjects;

    public void Mouse(GameObject go)
    {
        Debug.Log("First part");
        for (int i = 0; i < gameobjects.Length; i++)
        {
            Debug.Log("Second part");
            if (go == gameobjects[i])
            {
                Debug.Log("Third part");
                currentMaterial = go.GetComponent<MeshRenderer>().material;
            }
        }
        Debug.Log("Fourth part");
        for (int j = 0; j < materials.Length; j++)
        {
            Debug.Log("Fifth part");
            //if (currentMaterial == materials[j])
            //{
                //Debug.Log("Six part");
                go.GetComponent<MeshRenderer>().material = currentMaterial;

           // }
        }
    }


    public void CheckDine()
    {

    }
}
