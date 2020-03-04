using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
//<<<<<<< Updated upstream

//=======
    DialogueManager dm = new DialogueManager();
    
//>>>>>>> Stashed changes
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
        {
            Debug.Log("Player Detected");
            if (Input.GetKeyUp(KeyCode.Space))
            {
                TriggerDialogue();
            }

//<<<<<<< Updated upstream
//=======
            if (Input.GetKeyUp(KeyCode.Space) && dm.CheckDone() == true)
            {
                TriggerSpokeDialogue();
            }
            
//>>>>>>> Stashed changes
        }


    }

    public void TriggerSpokeDialogue()
    {
        FindObjectOfType<DialogueManager>().AlreadyTalked(dialogue);

    }
}
