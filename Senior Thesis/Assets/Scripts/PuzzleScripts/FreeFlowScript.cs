using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public bool correctcolororange = false;
    public bool correctcolorpink = false;
    public bool correctcolordarkblue = false;
    public bool correctcolorpurple = false;
    public bool correctcolorgreen = false;
    public bool correctcolorteal = false;
    public bool correctcoloryellow = false;
    public bool correctcolorlightblue = false;
    public bool correctcolorred = false;
    public bool correctcolorlilac = false;

    public Material currentMaterial;

    public Material[] materials;
    public GameObject[] gameobjects;
    //public GameObject[] allgrid;

    GameObject[] orangeTag;
    GameObject[] pinkTag;
    GameObject[] darkblueTag;
    GameObject[] purpleTag;
    GameObject[] greenTag;
    GameObject[] tealTag;
    GameObject[] yellowTag;
    GameObject[] lightblueTag;
    GameObject[] redTag;
    GameObject[] lilacTag;

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
        CheckDine();
    }


    public bool CheckDine()
    {
        for(int i = 0; i < orangeTag.Length; i++)
        {
            if(orangeTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[4])
            {
                correctcolororange = true;
            }
            else
            {
                correctcolororange = false;
                break;
            }
            break;
        }
        for (int i = 0; i < pinkTag.Length; i++)
        {
            if (pinkTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[5])
            {
                correctcolorpink = true;
            }
            else
            {
                correctcolorpink = false;
                break;
            }
            break;
        }
        for (int i = 0; i < darkblueTag.Length; i++)
        {
            if (darkblueTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[0])
            {
                correctcolordarkblue = true;
            }
            else
            {
                correctcolordarkblue = false;
                break;
            }
            break;
        }
        for (int i = 0; i < purpleTag.Length; i++)
        {
            if (purpleTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[6])
            {
                correctcolorpurple = true;
            }
            else
            {
                correctcolorpurple = false;
                break;
            }
            break;
        }
        for (int i = 0; i < greenTag.Length; i++)
        {
            if (greenTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[1])
            {
                correctcolorgreen = true;
            }
            else
            {
                correctcolorgreen = false;
                break;
            }
            break;
        }
        for (int i = 0; i < tealTag.Length; i++)
        {
            if (tealTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[8])
            {
                correctcolorteal = true;
            }
            else
            {
                correctcolorteal = false;
                break;
            }
            break;
        }
        for (int i = 0; i < yellowTag.Length; i++)
        {
            if (yellowTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[9])
            {
                correctcoloryellow = true;
            }
            else
            {
                correctcoloryellow = false;
                break;
            }
            break;
        }
        for (int i = 0; i < lightblueTag.Length; i++)
        {
            if (lightblueTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[2])
            {
                correctcolorlightblue = true;
            }
            else
            {
                correctcolorlightblue = false;
                break;
            }
            break;
        }
        for (int i = 0; i < redTag.Length; i++)
        {
            if (redTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[7])
            {
                correctcolorred = true;
            }
            else
            {
                correctcolorred = false;
                break;
            }
            break;
        }
        for (int i = 0; i < lilacTag.Length; i++)
        {
            if (lilacTag[i].gameObject.GetComponent<MeshRenderer>().material == materials[3])
            {
                correctcolorlilac = true;
            }
            else
            {
                correctcolorlilac = false;
                break;
            }
            break;
        }

        if (correctcolororange == true && correctcolorpink == true && correctcolordarkblue == true && correctcolorpurple == true && correctcolorgreen == true && correctcolorteal == true && correctcoloryellow == true && correctcolorlightblue == true && correctcolorred == true && correctcolorlilac == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Update()
    {
        if (CheckDine() == true)
        {
            //Scene transistion
            GlobalVariables.beatFreeFlow = true;
            SceneManager.LoadScene("MachineRoom");
        }

        //do a tag finder to add to array/list of the colors. need to tag each quad piece in unity that needs to be that color with the color name.
        orangeTag = GameObject.FindGameObjectsWithTag("Orange");
        pinkTag = GameObject.FindGameObjectsWithTag("Pink");
        darkblueTag = GameObject.FindGameObjectsWithTag("DarkBlue");
        purpleTag = GameObject.FindGameObjectsWithTag("Purple");
        greenTag = GameObject.FindGameObjectsWithTag("Green");
        tealTag = GameObject.FindGameObjectsWithTag("Teal");
        yellowTag = GameObject.FindGameObjectsWithTag("Yellow");
        lightblueTag = GameObject.FindGameObjectsWithTag("LightBlue");
        redTag = GameObject.FindGameObjectsWithTag("Red");
        lilacTag = GameObject.FindGameObjectsWithTag("Lilac");

    }
}
