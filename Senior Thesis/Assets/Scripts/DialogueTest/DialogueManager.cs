using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;


    private bool inDialogue = false;
    public bool done = false;


    public Animator animator;

    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        done = false;
        animator.SetBool("IsOpen", true);
        GlobalVariables.currentlyTalking = true;

        this.inDialogue = true;



        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    public void Update()
    {
        if(this.inDialogue == true && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0){
            EndDialogue();
            done = true;
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));


    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        GlobalVariables.currentlyTalking = false;
    }

    public void AlreadyTalked(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        GlobalVariables.currentlyTalking = true;
        this.inDialogue = true;


        nameText.text = dialogue.name;
        dialogueText.text = "You have already talked to this person";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            EndDialogue();
        }
    }

    public bool CheckDone()
    {
        return done;
    }
}
