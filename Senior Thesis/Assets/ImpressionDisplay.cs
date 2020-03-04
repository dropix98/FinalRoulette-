using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ImpressionDisplay : MonoBehaviour
{
    public Impression impression;

    public Text nameCharacter;
    public Text impressionShort;
    public Text impressionDescription;  
    void Update()
    {
        nameCharacter.text = impression.nameOfCharacter;
        impressionShort.text = impression.impressionShort;
        impressionDescription.text = impression.impressionDescription; 
    }

    
}
