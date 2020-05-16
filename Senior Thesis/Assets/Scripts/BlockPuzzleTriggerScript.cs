using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockPuzzleTriggerScript : MonoBehaviour
{

    public int num;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
        {
            Debug.Log("Player Detected");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("BlockTutorial");
            }
        }
    }
}
