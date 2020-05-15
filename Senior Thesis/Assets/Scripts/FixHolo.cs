using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixHolo : MonoBehaviour
{

    public GameObject one;
    public GameObject two;
    public GameObject three;

    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 0 && GlobalVariables.powerOn == true)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            counter++;
        }
        else
        {
            
        }
    }
}
