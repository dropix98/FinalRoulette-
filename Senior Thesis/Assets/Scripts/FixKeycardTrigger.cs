using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixKeycardTrigger : MonoBehaviour
{

    public GameObject trig;

FinalKeypad fk = new FinalKeypad();

    // Start is called before the first frame update
    void Start()
    {
        trig.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (fk.Ret() == true)
        {
            Destroy(trig.gameObject);
            trig.gameObject.SetActive(false);
        }

        
    }

    
}
