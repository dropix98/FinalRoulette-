using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
        {
            Debug.Log("Player Detected");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TriggerDialogue();
            }

        }
    }
}
