using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Vector3;
//using System.Object;
//using UnityEngine.StateChange;

public class Circulatory : MonoBehaviour
{
    int num_cholesterol, num_sugar;
    float x,y,z;
    int num_insulin = 150;
    //GameObject StageManager;
    float speed = 3.0f;
    bool state;
    GameObject sugar;
    GameObject insulin;
    GameObject k;
    float[] positionX_sugar;
    float[] positionY_sugar;
    GameObject[] list_insulin;

    void Start()
    {
        state = false;
        //StageManager = GameObject.Find("bloodSugar"); //혈당 변수 찾기
        //num_sugar = StageManager.GetComponent<StateChange>.bloodSugar; //혈당 변수 가져오기
        num_sugar = StateChange.bloodSugar;

        float[] positionX_sugar = new float[num_sugar];
        float[] positionY_sugar = new float[num_sugar];
        float[] positionX_insulin = new float[num_insulin];
        float[] positionY_insulin = new float[num_insulin];
        GameObject[] list_sugar = new GameObject[num_sugar];
        GameObject[] list_insulin = new GameObject[num_insulin];
        
        for ( int i = 0 ; i < num_sugar ; i++ ){ //혈당 수만큼 캐릭터 생성 
            float randomX = Random.Range(0f, 1920f); //랜덤 위치
            float randomY = Random.Range(0f, 1080f);
            positionX_sugar[i] = randomX;
            positionY_sugar[i] = randomY;
            sugar = (GameObject)Instantiate(sugar, new Vector3(randomX, randomY, 0f), Quaternion.identity);
            list_sugar[i] = sugar;
        }

        for ( int i = 0 ; i < num_insulin ; i++ ){ //인슐린 수만큼 캐릭터 생성 
            float randomX = Random.Range(0f, 1920f); //랜덤 위치
            float randomY = Random.Range(0f, 1080f);
            positionX_insulin[i] = randomX;
            positionY_insulin[i] = randomY;
            insulin = (GameObject)Instantiate(insulin, new Vector3(randomX, randomY, 0f), Quaternion.identity);
            list_insulin[i] = insulin;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        for ( int i = 0 ; i < num_insulin ; i++ ){ //인슐린이 혈당 캐치
        x = positionX_sugar[i];
        y = positionY_sugar[i];
        k = list_insulin[i];
        //k = Vector3.MoveTowards(k, new Vector3(x, y, 0), Time.deltaTime * speed);
        }

    }
}
