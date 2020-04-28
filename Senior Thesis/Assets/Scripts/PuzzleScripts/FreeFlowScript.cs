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


    public bool done = false;
    public Material currentMaterial;

    public Material[] materials;
    public GameObject[] gameobjects;
    //public GameObject[] allgrid;

    public GameObject[] orangeTag;
    public GameObject[] pinkTag;
    public GameObject[] darkblueTag;
    public GameObject[] purpleTag;
    public GameObject[] greenTag;
    public GameObject[] tealTag;
    public GameObject[] yellowTag;
    public GameObject[] lightblueTag;
    public GameObject[] redTag;
    public GameObject[] lilacTag;


    private void Start()
    {
       /* orangeTag = GameObject.FindGameObjectsWithTag("Orange");
        pinkTag = GameObject.FindGameObjectsWithTag("Pink");
        darkblueTag = GameObject.FindGameObjectsWithTag("DarkBlue");
        purpleTag = GameObject.FindGameObjectsWithTag("Purple");
        greenTag = GameObject.FindGameObjectsWithTag("Green");
        tealTag = GameObject.FindGameObjectsWithTag("Teal");
        yellowTag = GameObject.FindGameObjectsWithTag("Yellow");
        lightblueTag = GameObject.FindGameObjectsWithTag("LightBlue");
        redTag = GameObject.FindGameObjectsWithTag("Red");
        lilacTag = GameObject.FindGameObjectsWithTag("Lilac");
        */
    }
    public void Mouse(GameObject go)
    {
        //Debug.Log("First part");
        for (int i = 0; i < gameobjects.Length; i++)
        {
           // Debug.Log("Second part");
            if (go == gameobjects[i])
            {
                //Debug.Log("Third part");
                currentMaterial = go.GetComponent<MeshRenderer>().sharedMaterial;
            }
        }
        //Debug.Log("Fourth part");
        for (int j = 0; j < materials.Length; j++)
        {
            //Debug.Log("Fifth part");
            //if (currentMaterial == materials[j])
            //{
                //Debug.Log("Six part");
                go.GetComponent<MeshRenderer>().sharedMaterial = currentMaterial;

           // }
        }
        
    }


    public void Update()
    {
        for(int k = 0; k < orangeTag.Length - 1; k++)
        {
            if(orangeTag[k].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[4])
            {
                correctcolororange = true;
                Debug.Log("HereO");
            }
            else
            {
                correctcolororange = false;
            }

           // break;
        }
        for (int l = 0; l < pinkTag.Length - 1; l++)
        {
            if (pinkTag[l].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[5])
            {
                correctcolorpink = true;
                Debug.Log("HerePI");
            }
            else
            {
                correctcolorpink = false;
            }

            //break;
        }
        for (int m = 0; m < darkblueTag.Length - 1; m++)
        {
            if (darkblueTag[m].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[0])
            {
                correctcolordarkblue = true;
                Debug.Log("HereDB");
            }
            else
            {
                correctcolordarkblue = false;
            }

            //  break;
        }
        for (int n = 0; n < purpleTag.Length - 1; n++)
        {
            if (purpleTag[n].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[6])
            {
                correctcolorpurple = true;
                Debug.Log("HereP");
            }
            else
            {
                correctcolorpurple = false;
            }

            // break;
        }
        for (int o = 0; o < greenTag.Length - 1; o++)
        {
            if (greenTag[o].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[1])
            {
                correctcolorgreen = true;
                Debug.Log("HereG");
            }
            else
            {
                correctcolorgreen = false;
            }

            // break;
        }
        for (int p = 0; p < tealTag.Length - 1; p++)
        {
            if (tealTag[p].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[8])
            {
                correctcolorteal = true;
                Debug.Log("HereT");
            }
            else
            {
                correctcolorteal = false;
            }

            // break;
        }
        for (int q = 0; q < yellowTag.Length - 1; q++)
        {
            if (yellowTag[q].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[9])
            {
                correctcoloryellow = true;
                Debug.Log("HereY");
            }
            else
            {
                correctcoloryellow = false;
            }

            // break;
        }
        for (int r = 0; r < lightblueTag.Length - 1; r++)
        {
            if (lightblueTag[r].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[2])
            {
                correctcolorlightblue = true;
                Debug.Log("HereLB");
            }
            else
            {
                correctcolorlightblue = false;
            }

            // break;
        }
        for (int r = 0; r < redTag.Length - 1; r++)
        {
            if (redTag[r].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[7])
            {
                correctcolorred = true;
                Debug.Log("HereR");
            }
            else
            {
                correctcolorred = false;
            }

            // break;
        }
        for (int s = 0; s < lilacTag.Length -1; s++)
        {
            
            if (lilacTag[s].gameObject.GetComponent<MeshRenderer>().sharedMaterial == materials[3])
            {
                correctcolorlilac = true;
                Debug.Log("HereL");
            }
            else
            {
                correctcolorlilac = false;
            }

            //break;
        }

        if (correctcolororange == true && correctcolorpink == true && correctcolordarkblue == true && correctcolorpurple == true && correctcolorgreen == true && correctcolorteal == true && correctcoloryellow == true && correctcolorlightblue == true && correctcolorred == true && correctcolorlilac == true)
        {
            Debug.Log("Heretrue");
            done = true;
        }
        else
        {
            Debug.Log("Hereelse");
            done = false;
        }

        if (done == true)
        {
            //Scene transistion
            Debug.Log("Hereupdate");
            GlobalVariables.beatFreeFlow = true;
            SceneManager.LoadScene("MachineRoom");
        }

        //do a tag finder to add to array/list of the colors. need to tag each quad piece in unity that needs to be that color with the color name.
        /*orangeTag = GameObject.FindGameObjectsWithTag("Orange");
        pinkTag = GameObject.FindGameObjectsWithTag("Pink");
        darkblueTag = GameObject.FindGameObjectsWithTag("DarkBlue");
        purpleTag = GameObject.FindGameObjectsWithTag("Purple");
        greenTag = GameObject.FindGameObjectsWithTag("Green");
        tealTag = GameObject.FindGameObjectsWithTag("Teal");
        yellowTag = GameObject.FindGameObjectsWithTag("Yellow");
        lightblueTag = GameObject.FindGameObjectsWithTag("LightBlue");
        redTag = GameObject.FindGameObjectsWithTag("Red");
        lilacTag = GameObject.FindGameObjectsWithTag("Lilac");
        */
    }
    
}
