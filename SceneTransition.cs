using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Change name based on what place you are trying to go to
        //add more to transition to more scenes.
        if (collision.name == "elevatorEntrace") {
            //needs to use int. determine based on the building of the scenes in the unity builder
            SceneManager.LoadScene(2);
        }
    }
}
