using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OminousVoice : MonoBehaviour
{
    public GameObject Voice;

    // Start is called before the first frame update
    void Start()
    {
      Voice.GetComponent<DialogueTrigger>().TriggerDialogue();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
