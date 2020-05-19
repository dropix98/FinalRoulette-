using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeycardalreadyCollect : MonoBehaviour
{
    public GameObject kk;
    public GameObject dia;
   

    public bool switchd = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(dia);
        DontDestroyOnLoad(kk);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("FemaleBathroom1") && switchd == true)
        {
            kk.gameObject.SetActive(false);
        }
        else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("FemaleBathroom1") && switchd == true && GlobalVariables.fromFemaleBathroomCollider1 == true)
        {
            kk.gameObject.SetActive(false);
        }

        switchd = GlobalVariables.foundKeycard;
    }
}
