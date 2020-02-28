using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;
    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].rotation.z == 90.00001)
        {
            youWin = true;
            winText.gameObject.SetActive(true);

        }
    }
}
