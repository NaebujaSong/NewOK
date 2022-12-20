using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class warning1 : MonoBehaviour
{
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject slider4;
void Start(){
}

    public void click(){
        slider1.SetActive(true);
        slider2.SetActive(false);
        slider3.SetActive(false);
        slider4.SetActive(false);
    }
}
