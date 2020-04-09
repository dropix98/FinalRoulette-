using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel3Script : MonoBehaviour
{

    public string sceneName;
    public string temp;

    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
