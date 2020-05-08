using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;
using UnityEngine.SceneManagement;


public class LoadingScript : MonoBehaviour
{
    public string Scene;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Coroutine()
    {
      yield return new WaitForSeconds(6);
      SceneManager.LoadScene(Scene);
    }
}
