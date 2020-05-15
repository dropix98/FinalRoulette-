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
    public Animator bounce;

    private Queue<string> sentences;
    private Queue<GameObject> spritesList;

    public Dialogue nd;

    public int sentCount = 0;
    void Start()
    {
        sentences = new Queue<string>();
        spritesList = new Queue<GameObject>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        pmc.movementSpeed = 0;
        bounce.enabled = false;
        for (int i = 0; i < trig.Length; i++) {
            //trig[i].gameObject.SetActive(false);
            //trig[i].gameObject.GetComponent<DialogueManager>().enabled = false;
            //if (trig[i].gameObject.GetComponent<SpriteRenderer>().sprite == true) {
            //    trig[i].gameObject.GetComponent<DialogueTrigger>().enabled = true;
            //}
            if (trig[i].gameObject.GetComponent<SpriteRenderer>())
            {
                Debug.Log("if");
                trig[i].gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                Debug.Log("else");
                trig[i].gameObject.SetActive(false);
            }
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
        //Debug.Log("++");
        sentCount++;

        //LEVEL 4 DIALOGUE NAME FIXES. SENTCOUNT IS 1 LESS THAN THE ELEMENT NUMBER OF THE DIALOGUE ELEMENT IN THE DIALOGUE TRIGGER SENTENCES PART. IF IT IS THE 4TH SENTENCE THE SENTCOUNT IS 3
        //sentcount needs to change fyi kyle burack
        if (sentCount == 4 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4Scene"))
        {
            
            //nameText.text = "TESTNAME";
        }
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
        bounce.enabled = true;
        GlobalVariables.currentlyTalking = false;
        for (int i = 0; i < trig.Length; i++)
        {
            //trig[i].gameObject.SetActive(true);
            //trig[i].gameObject.GetComponent<DialogueManager>().enabled = true;
            if (trig[i].gameObject.GetComponent<SpriteRenderer>())
            {
                
                trig[i].gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                
                trig[i].gameObject.SetActive(true);
            }
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



        if (GlobalVariables.switchingFuseColliders == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge"))
        {
            //fuse switch
            trig[7].gameObject.SetActive(false);
            //trig[7].gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.powerOn == false)
        {
            //dragon,snake,rabbit
            trig[11].gameObject.SetActive(false);
            trig[12].gameObject.SetActive(false);
            trig[13].gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.powerOn == true)
        {
            trig[11].gameObject.SetActive(true);
            trig[12].gameObject.SetActive(true);
            trig[13].gameObject.SetActive(true);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.talkedYZ2 == true && GlobalVariables.hasMedReport == true && GlobalVariables.powerOn == true)
        {
            //drangon2,snake2,rabbit2 switch
            trig[11].gameObject.SetActive(false);
            trig[12].gameObject.SetActive(false);
            trig[13].gameObject.SetActive(false);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.switchingXJColliders == true)
        {
            //xjcollider2
            trig[2].gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.switchingXJColliders == false)
        {
            trig[3].gameObject.SetActive(false);
        }
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.hasCube == true)
        {
            //cube
            trig[8].gameObject.SetActive(false);
        }
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge") && GlobalVariables.hasWire == true)
        {
            trig[14].gameObject.SetActive(false);
        }



        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Infirmary"))
        {
            trig[3].gameObject.SetActive(false);
            trig[2].gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Infirmary") && GlobalVariables.switchingDrawerColliders == true)
        {
            trig[2].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(true);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Infirmary"))
        {
            trig[5].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Infirmary") && GlobalVariables.switchingHoleColliders == true)
        {
            trig[4].gameObject.SetActive(false);
            trig[5].gameObject.SetActive(true);
        }




        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MachineRoom") && GlobalVariables.beatFreeFlow == false)
        {
            
            trig[3].gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MachineRoom") && GlobalVariables.beatFreeFlow == true)
        {

            trig[3].gameObject.SetActive(true);
        }
        if(GlobalVariables.hasSuRongDNA == true && GlobalVariables.hasYingDNA == true &&
          GlobalVariables.hasYiZhengDNA == true && GlobalVariables.hasYongRuanDNA == true &&
          GlobalVariables.hasJanitorDNA == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MachineRoom"))
        {
            trig[3].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(true);
        }
        else if(GlobalVariables.hasSuRongDNA == false || GlobalVariables.hasYingDNA == false ||
          GlobalVariables.hasYiZhengDNA || false || GlobalVariables.hasYongRuanDNA == false ||
          GlobalVariables.hasJanitorDNA || false && GlobalVariables.beatFreeFlow == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MachineRoom"))
        {
            trig[4].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(true);
        }
        if (GlobalVariables.switchJanitor3Collider == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MachineRoom"))
        {
            trig[5].gameObject.SetActive(false);
            trig[0].gameObject.SetActive(true);
        }
        else if (GlobalVariables.switchJanitor3Collider == false && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MachineRoom"))
        {
            trig[0].gameObject.SetActive(false);
            trig[5].gameObject.SetActive(true);
        }


        //
        if (GlobalVariables.sawInvestigationReport == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.beatFreeFlow == false)
        {
            trig[0].gameObject.SetActive(false);
            trig[10].gameObject.SetActive(true);
        }

            if (GlobalVariables.sawInvestigationReport == false && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.beatFreeFlow == false)
        {
            trig[0].gameObject.SetActive(true);
            trig[10].gameObject.SetActive(false);
            trig[11].gameObject.SetActive(false);
        }

        if (GlobalVariables.sawInvestigationReport == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.beatFreeFlow == true)
        {
            trig[10].gameObject.SetActive(false);
            trig[11].gameObject.SetActive(true);
        }
        

        if (GlobalVariables.hasMedicalPills == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom"))
        {
            trig[3].gameObject.SetActive(false);
            trig[16].gameObject.SetActive(true);
        }
        if (GlobalVariables.hasMedicalPills == false && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom"))
        {
            trig[16].gameObject.SetActive(false);
            trig[3].gameObject.SetActive(true);
        }


        if (GlobalVariables.beatFreeFlow == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.beatSimonSays == false)
        {
            trig[2].gameObject.SetActive(false);
            trig[14].gameObject.SetActive(true);
        }
        if (GlobalVariables.beatFreeFlow == false && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.beatSimonSays == false)
        {
            trig[14].gameObject.SetActive(false);
            trig[2].gameObject.SetActive(true);
        }


        if (GlobalVariables.beatFreeFlow == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.hasDNAResults == false)
        {
            trig[1].gameObject.SetActive(false);
            trig[12].gameObject.SetActive(true);
        }
        if (GlobalVariables.beatFreeFlow == false && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.hasDNAResults == false)
        {
            trig[12].SetActive(false);
            trig[1].SetActive(true);
        }
        //

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.hasDNAResults == true)
        {
            trig[1].gameObject.SetActive(false);
            trig[12].gameObject.SetActive(false);
            trig[13].gameObject.SetActive(true);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom"))
        {
            trig[1].gameObject.SetActive(true);
            trig[12].gameObject.SetActive(false);
            trig[13].gameObject.SetActive(false);
        }


        if (GlobalVariables.beatSimonSays == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.beatFreeFlow == true)
        {
            trig[2].gameObject.SetActive(false);
            trig[14].gameObject.SetActive(false);
            trig[15].gameObject.SetActive(true);
        }
        else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom"))
        {
            trig[2].gameObject.SetActive(true);
            trig[14].gameObject.SetActive(false);
            trig[15].gameObject.SetActive(false);
        }
        

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.switchToolboxCollider == true)
        {
            trig[5].gameObject.SetActive(false);
            trig[6].gameObject.SetActive(true);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.switchToolboxCollider == false)
        {
            trig[6].gameObject.SetActive(false);
            trig[5].gameObject.SetActive(true);
        }


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom") && GlobalVariables.hasCrowbar == true)
        {
            trig[8].gameObject.SetActive(false);
        }

        if (GlobalVariables.PhotoHint == true && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BroadcastingRoom"))
        {
            trig[9].gameObject.SetActive(false);
            trig[4].gameObject.SetActive(false);
        }

        nameText.text = "";
        sentCount = 0;
        bounce.enabled = true;
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
