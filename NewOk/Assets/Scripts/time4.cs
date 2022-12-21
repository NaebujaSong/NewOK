using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time4 : MonoBehaviour
{
    static public Slider slTimer4;
    public float fSliderBarTime;
    void Start() {
        slTimer4 = GetComponent<Slider>();
    }
 
    void Update()
    {
        if (time1.slTimer1.value >= 1.0f && time2.slTimer2.value >= 1.0f && time3.slTimer3.value >= 1.0f){
            if (slTimer4.value < 1.0f) {
                slTimer4.value += 0.4f * Time.deltaTime;
            }
            else{
                time1.notStart4 = 1;
            }
        }
    }
}
