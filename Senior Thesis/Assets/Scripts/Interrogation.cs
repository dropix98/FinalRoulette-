using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrogation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InterrogateYing()
    {
      GlobalVariables.interrogatingYing = true;
    }
    public void InterrogateSuRong()
    {
      GlobalVariables.interrogatingSuRong = true;
    }
    public void InterrogateYiZheng()
    {
      GlobalVariables.interrogatingYiZheng = true;
    }
    public void InterrogateXiaoJing()
    {
      GlobalVariables.interrogatingXiaoJing = true;
    }
    public void InterrogateYingHei()
    {
      GlobalVariables.interrogatingYingHei = true;
    }
    public void InterrogateShaoTing()
    {
      GlobalVariables.interrogatingShaoTing = true;
    }
    public void InterrogateYongRuan()
    {
      GlobalVariables.interrogatingYongRuan = true;
    }
    public void InterrogatePinBi()
    {
      GlobalVariables.interrogatingPinBi = true;
    }
    public void InterrogateMinKai()
    {
      GlobalVariables.interrogatingMinKai = true;
    }
}
