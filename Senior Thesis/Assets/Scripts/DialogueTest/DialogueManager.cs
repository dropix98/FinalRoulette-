using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public GameObject characterSprite;

    public GameObject[] trig;

    private bool inDialogue = false;
    public bool done = false;

    public PlayerMovementController pmc;

    public Animator animator;

    private Queue<string> sentences;
    private Queue<GameObject> spritesList;

    void Start()
    {
        sentences = new Queue<string>();
        spritesList = new Queue<GameObject>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        pmc.movementSpeed = 0;
        for (int i = 0; i < trig.Length; i++) {
            trig[i].gameObject.SetActive(false);
        }
        done = false;
        animator.SetBool("IsOpen", true);
        GlobalVariables.currentlyTalking = true;

        this.inDialogue = true;




        nameText.text = dialogue.name;
        sentences.Clear();
        spritesList.Clear();


        foreach(string sentence in dialogue.sentences)
        {
          print("sentence");

            sentences.Enqueue(sentence);
        }

        foreach(GameObject image in dialogue.characterSprites)
        {
            //print("image");

            spritesList.Enqueue(image);
        }

        DisplayNextSentence();
    }


    public void Update()
    {
        if(this.inDialogue == true && Input.GetKeyUp(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            done = true;
            return;
        }
        /*if (spritesList.Count == 0)
        {
            characterSprite.GetComponent<Image>().sprite =
        }*/


        string sentence = sentences.Dequeue();

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        if (spritesList.Count != 0)
        {
          Sprite image = spritesList.Dequeue().GetComponent<SpriteRenderer>().sprite;
          characterSprite.GetComponent<Image>().sprite = image;
        }
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
        pmc.movementSpeed = 3;
        animator.SetBool("IsOpen", false);
        GlobalVariables.currentlyTalking = false;
        for (int i = 0; i < trig.Length; i++)
        {
            trig[i].gameObject.SetActive(true);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            trig[2].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(false);
            trig[6].gameObject.SetActive(false);
        }
        else if (GlobalVariables.itemsFound == 5 && GlobalVariables.numberOfPeopleTalkedTo == 9 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            trig[2].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(false);
            trig[5].gameObject.SetActive(false);
        }
        else if (GlobalVariables.itemsFound == 5 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            trig[5].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(false);
            trig[6].gameObject.SetActive(false);
        }
        else if (GlobalVariables.numberOfPeopleTalkedTo == 9 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            trig[2].gameObject.SetActive(false);
            trig[5].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(false);
            trig[6].gameObject.SetActive(false);
        }
        else if (GlobalVariables.foundKeycard && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Floor1Final"))
        {
            trig[2].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(false);
            trig[5].gameObject.SetActive(false);
            trig[6].gameObject.SetActive(false);
        }
    }

    public void AlreadyTalked(Dialogue dialogue)
    {
        for (int i = 0; i < trig.Length; i++)
        {
            trig[i].gameObject.SetActive(false);
        }
        pmc.movementSpeed = 0;
        animator.SetBool("IsOpen", true);
        GlobalVariables.currentlyTalking = true;
        this.inDialogue = true;

        nameText.text = dialogue.name;
        dialogueText.text = "You have already talked to this person";

        if (Input.GetKeyUp(KeyCode.Space))
        {
            EndDialogue();
        }
    }

    public bool CheckDone()
    {
        return done;
    }
}
