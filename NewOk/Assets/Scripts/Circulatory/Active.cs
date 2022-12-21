using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren_Circulatory : MonoBehaviour
{
    bool state;
    GameObject target;
    GameObject StateManager;
    int num_sugar, num_insulin;

    // Start is called before the first frame update
    void Start()
    {
        state = false;
        //StageManager = GameObject.Find("num_sugar"); //혈당 변수 찾기
        //num_sugar = StageManager.GetComponent<SceneChange>.num_sugar; //혈당 변수 가져오기
        //StageManager = GameObject.Find("num_insulin"); //인슐린 변수 찾기
        //num_insulin = StageManager.GetComponent<SceneChange>.num_insulin; //인슐린 변수 가져오기

        num_sugar = StateChange.bloodSugar;
        int num_insulin = 150;
    }

    // Update is called once per frame
    void Update()
    {
        if (num_sugar > num_insulin){
            target.SetActive(true);
            state = true;
        }
        else{
            target.SetActive(false);
            state = false;
        }
    }
}
