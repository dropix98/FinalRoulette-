using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockPuzzle : MonoBehaviour
{
    string objectName = "";
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    public bool startingPiece;
    public GameObject nextInLine;
    bool printBool = true;
    bool completed = false;

    LoungeManager lm = new LoungeManager();

    public GameObject fintext;

    // Start is called before the first frame update
    void Start()
    {

        fintext.gameObject.SetActive(false);

      if (!startingPiece)
      {
        this.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
      }
    }

    // Update is called once per frame
    void Update()
    {
      if (tile1.activeInHierarchy && tile2.activeInHierarchy && tile3.activeInHierarchy && tile4.activeInHierarchy && printBool)
      {
            printBool = false;
            completed = true;
            if (lm.GetSlide() == false)
            {
                //DontDestroyOnLoad(GameObject.Find("GameManager"));
            }
            lm.UpdateBlock(true);
            GlobalVariables.finishedBlock = true;
            fintext.gameObject.SetActive(true);

        }
        if (completed)
        {
          if (Input.GetKeyDown(KeyCode.Space))
          {
              SceneManager.LoadScene("FinishedCubePuzzle");
          }
        }
    }

    void OnMouseDown()
    {
      objectName = this.gameObject.name;
      this.gameObject.SetActive(false);
      nextInLine.gameObject.SetActive(true);
      Debug.Log(objectName);
    }
}
