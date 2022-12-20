using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.StateChange;

public class Circulatory : MonoBehaviour
{
    int num_cholesterol, num_sugar;
    int num_insulin = 150;
    GameObject StageManager;
    float speed = 3.0f;
    bool state;

    void Start()
    {
        state = false;
        StageManager = GameObject.Find("bloodSugar"); //혈당 변수 찾기
        num_sugar = StageManager.GetComponent<StateChange>.bloodSugar; //혈당 변수 가져오기

        int[] positionX_sugar = new int[num_sugar];
        int[] positionY_sugar = new int[num_sugar];
        int[] positionX_insulin = new int[num_insulin];
        int[] positionY_insulin = new int[num_insulin];
        GameObject[] list_sugar = new GameObject[num_sugar];
        GameObject[] list_insulin = new GameObject[num_insulin];
        
        for ( int i = 0 ; i < num_sugar ; i++ ){ //혈당 수만큼 캐릭터 생성 
            float randomX = Random.Range(0f, 1920f); //랜덤 위치
            float randomY = Random.Range(0f, 1080f);
            positionX_sugar[i] = randomX;
            positionY_sugar[i] = randomY;
            GameObject sugar = (GameObject)Instantiate(obj, new Vextor3(randomX, randomY, 0f), Quaternion.identity);
            list_sugar[i] = sugar;
        }

        for ( int i = 0 ; i < num_insulin ; i++ ){ //인슐린 수만큼 캐릭터 생성 
            float randomX = Random.Range(0f, 1920f); //랜덤 위치
            float randomY = Random.Range(0f, 1080f);
            positionX_insulin[i] = randomX;
            positionY_insulin[i] = randomY;
            GameObject insulin = (GameObject)Instantiate(obj, new Vextor3(randomX, randomY, 0f), Quaternion.identity);
            list_insulin[i] = insulin;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        for ( int i = 0 ; i < num_insulin ; i++ ){ //인슐린이 혈당 캐치
        transform.insulin[i] = Vector3.MoveTowards(transform.insulin[i], 
        new Vector3(positionX_sugar, positionY_sugar, 0), Time.deltaTime * speed);
        }

    }
}
