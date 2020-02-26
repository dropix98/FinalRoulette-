﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
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
        print("Congrats");
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