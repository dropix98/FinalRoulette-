using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeypadTextScriptSetActives : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject both;
    public GameObject items;
    public GameObject people;
    public GameObject keycard;
    public GameObject none;

    void Start()
    {
        both.gameObject.SetActive(false);
        items.gameObject.SetActive(false);
        people.gameObject.SetActive(false);
        keycard.gameObject.SetActive(false);
        none.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.itemsFound == 5 && GlobalVariables.numberOfPeopleTalkedTo == 9 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            both.gameObject.SetActive(true);
            items.gameObject.SetActive(false);
            people.gameObject.SetActive(false);
            keycard.gameObject.SetActive(false);
            none.gameObject.SetActive(false);
        }
        else if (GlobalVariables.itemsFound == 5 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            both.gameObject.SetActive(false);
            items.gameObject.SetActive(true);
            people.gameObject.SetActive(false);
            keycard.gameObject.SetActive(false);
            none.gameObject.SetActive(false);
        }
        else if (GlobalVariables.numberOfPeopleTalkedTo == 9 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            both.gameObject.SetActive(false);
            items.gameObject.SetActive(false);
            people.gameObject.SetActive(true);
            keycard.gameObject.SetActive(false);
            none.gameObject.SetActive(false);
        }
        else if (GlobalVariables.foundKeycard && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            both.gameObject.SetActive(false);
            items.gameObject.SetActive(false);
            people.gameObject.SetActive(false);
            keycard.gameObject.SetActive(true);
            none.gameObject.SetActive(false);
            GlobalVariables.triedKeycardOnDoor = true;
        }
    }
}
