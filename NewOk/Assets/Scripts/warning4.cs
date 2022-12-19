using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning4 : MonoBehaviour
{
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject slider4;

void Start(){
}
    public void click(){
        slider1.SetActive(false);
        slider2.SetActive(false);
        slider3.SetActive(false);
        slider4.SetActive(true);
    }
}
