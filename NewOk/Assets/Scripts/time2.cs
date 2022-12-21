using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class time2 : MonoBehaviour
{
    static public Slider slTimer2;
    public float fSliderBarTime;
    void Start() {
        slTimer2 = GetComponent<Slider>();
    }
 
    void Update()
    {
        if (time1.slTimer1.value >= 1.0f){
            if (slTimer2.value < 1.0f) {
                slTimer2.value += 0.3f * Time.deltaTime;
            }
            else{
                time1.notStart2 = 1;
            }
        }
    }
}
