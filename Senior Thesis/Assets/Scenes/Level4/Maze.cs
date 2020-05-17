using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public GameObject ToyText;
    public GameObject BloodText;
    public GameObject ReportText;

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
        if (other.name == "ToyCollider")
        {
          ToyText.GetComponent<DialogueTrigger>().TriggerDialogue();
          ToyText.SetActive(false);
          print("hello");
        }
        if (other.name == "BloodCollider")
        {
          BloodText.GetComponent<DialogueTrigger>().TriggerDialogue();
          BloodText.SetActive(false);
        }
        if (other.name == "ReportCollider")
        {
          ReportText.GetComponent<DialogueTrigger>().TriggerDialogue();
          ReportText.SetActive(false);
        }
    }
}
