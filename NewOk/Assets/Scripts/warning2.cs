using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warning2 : MonoBehaviour
{
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject slider4;
    public Button button;

void Start(){
}

void Update(){
    ColorBlock colorBlock = button.colors;
    if (time1.slTimer1.value == 1.0f && time1.notStart2 == 0){
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
        slider2.SetActive(true);
        slider3.SetActive(false);
        slider4.SetActive(false);
    }


}

