using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Script : MonoBehaviour
{
    public GameObject StartingDialogue;
    public GameObject buttonEnter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnterMaze()
    {
      buttonEnter.SetActive(false);
      //approached = true;
      StartingDialogue.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
}
