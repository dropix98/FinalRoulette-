using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeppHoleLoaded : MonoBehaviour
{

    public GameObject ho;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.switchingHoleColliders == false)
        {
            ho.gameObject.SetActive(true);
        }
        else
        {
            ho.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GlobalVariables.switchingHoleColliders = true;
        }
    }
}
