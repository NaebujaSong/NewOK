using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren1 : MonoBehaviour
{

    bool state;
    GameObject target;
    //GameObject StateManager;
    int num_sugar;
    int num_insulin = 150;

    // Start is called before the first frame update
    void Start()
    {
        state = false;
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
