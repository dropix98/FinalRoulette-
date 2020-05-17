using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeppYZLoaded : MonoBehaviour
{
    public GameObject yz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yz.gameObject.SetActive(true);
    }
}
