using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class time1 : MonoBehaviour
{
    static public Slider slTimer1;
    static public float notStart2;
    static public float notStart3;
    static public float notStart4;
    static public float sl3;
    public float fSliderBarTime;
    static public float fin;
    void Start(){
        slTimer1 = GetComponent<Slider>();
        notStart2 = 0;
        notStart3 = 0;
        notStart4 = 0;
        sl3 = 0;
        fin = 0;
    }

    void Update(){
        
        if (warning1.Click == 2){
            if (slTimer1.value < 1.0f){
                slTimer1.value += 0.5f * Time.deltaTime;
            }
            else {
                Debug.Log("1배송끝");
            }
        }
    }
}
