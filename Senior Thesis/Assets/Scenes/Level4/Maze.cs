using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public GameObject Glitch1;
    public GameObject Glitch2;
    public GameObject Glitch3;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

    public GameObject Border;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Glitch1Collider")
        {
          Text1.GetComponent<DialogueTrigger>().TriggerDialogue();
          Glitch1.SetActive(false);
          print("hello");
        }
        if (other.name == "Glitch2Collider")
        {
          Text2.GetComponent<DialogueTrigger>().TriggerDialogue();
          Glitch2.SetActive(false);
        }
        if (other.name == "Glitch3Collider")
        {
          Text3.GetComponent<DialogueTrigger>().TriggerDialogue();
          Glitch3.SetActive(false);
        }
    }

    public void AfterConvo()
    {
      Border.SetActive(false);
    }
}
