using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneTriggerTestScript : MonoBehaviour
{
    // Start is called before the first frame updat

    public string sceneName;
    void Start()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

}
