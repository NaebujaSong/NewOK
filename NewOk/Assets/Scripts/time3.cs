using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time3 : MonoBehaviour
{
    static public Slider slTimer3;
    public float fSliderBarTime;
    void Start() {
        slTimer3 = GetComponent<Slider>();
    }
 
    void Update()
    {
        if (time1.slTimer1.value >= 1.0f && time2.slTimer2.value >= 1.0f){
            if (slTimer3.value < 1.0f) {
                slTimer3.value += 0.1f * Time.deltaTime;
            }
            else{
                Debug.Log("세번째 배송 끝");
            }
        }
    }
}
