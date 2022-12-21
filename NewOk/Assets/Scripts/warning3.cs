using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warning3 : MonoBehaviour
{
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject slider4;
    public Button button;

void Update(){
    ColorBlock colorBlock = button.colors;
    if (time2.slTimer2.value == 1.0f && time1.notStart3 == 0){
        colorBlock.normalColor = new Color(1f, 0f, 0f, 1f);
        button.colors = colorBlock;
    }
    else {
        colorBlock.normalColor = new Color(1f, 1f, 1f, 1f);
        button.colors = colorBlock;
    }
}
    public void click(){
        slider1.SetActive(false);
        slider2.SetActive(false);
        slider3.SetActive(true);
        slider4.SetActive(false);
    }
}