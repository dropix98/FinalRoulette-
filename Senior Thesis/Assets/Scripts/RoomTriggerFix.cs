using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTriggerFix : MonoBehaviour
{
    public GameObject trig;

    private float sec = 1f;

    // Start is called before the first frame update
    void Start()
    {
        trig.gameObject.SetActive(false);

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            trig.gameObject.SetActive(true);
        }
    }


}
