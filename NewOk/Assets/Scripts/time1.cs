using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class time1 : MonoBehaviour
{
    static public Slider slTimer1;
    public float fSliderBarTime;
    void Start(){
        slTimer1 = GetComponent<Slider>();
    }

    void Update(){
        if (slTimer1.value < 1.0f){
            slTimer1.value += 0.5f * Time.deltaTime;
        }
    }
}
