using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject slider4;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        slider1.SetActive(false);
        slider2.SetActive(false);
        slider3.SetActive(false);
        slider4.SetActive(false);
        time1.slTimer1.value = 0;
    }

    void Update(){
        ColorBlock colorBlock = button.colors;
        if (time1.slTimer1.value == 1.0f){
            colorBlock.normalColor = new Color(1f, 1f, 1f, 1f);
            button.colors = colorBlock;
        }

    }

}
