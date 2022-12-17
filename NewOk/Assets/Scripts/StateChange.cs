using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

class States 
{
    public const int HIGH = 70, NORMAL = 50, LOW = 30;
}

public class StateChange : MonoBehaviour
{
    // 변수명: 순서대로 근육량, 혈당, 수분량, 스트레스, 피로도
    public int muscleMass = 0, bloodSugar = 0, moisture= 0, stress = 0, fatigue = 0;

    public void ClickBtn() 
    {
        print("버튼 클릭");
        
        // 방금 클릭한 게임 오브젝트를 가져와서 저장
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        // 방금 클릭한 게임 오브젝트의 이름과 버튼 속 문자 출력
        print(clickObject.name);

        // 노션의 수치 변동 테이블 참고함
        // Training의 경우
        if(clickObject.name == "Strong"){
            muscleMass += States.HIGH;
            bloodSugar -= States.HIGH;
            moisture -= States.HIGH;
            stress -= States.HIGH;
            fatigue += States.HIGH;
        }
        if(clickObject.name == "Normal"){
            muscleMass += States.NORMAL;
            bloodSugar -= States.NORMAL;
            moisture -= States.NORMAL;
            stress -= States.NORMAL;
            fatigue += States.NORMAL;
        }
        if(clickObject.name == "DoNot"){
            muscleMass -= States.LOW;
            fatigue -= States.LOW;
        }

        // foodType의 경우
        if(clickObject.name == "HealthyFood"){
            muscleMass += States.NORMAL;
            bloodSugar += States.LOW;
            moisture += States.NORMAL;
            stress += States.NORMAL;
            fatigue += States.LOW;
        }
        if(clickObject.name == "NormalFood"){
            bloodSugar += States.NORMAL;
            fatigue -= States.LOW;
        }
        if(clickObject.name == "FastFood"){
            muscleMass -= States.LOW;
            bloodSugar += States.HIGH;
            stress -= States.HIGH;
            fatigue -= States.LOW;
        }

        // sleepTime의 경우
        if(clickObject.name == "LongTime"){
            bloodSugar -= States.HIGH;
            moisture -= States.HIGH;
            stress -= States.HIGH;
            fatigue -= States.HIGH;
        }
        if(clickObject.name == "NormalTime"){
            bloodSugar -= States.NORMAL;
            moisture -= States.NORMAL;
            stress -= States.NORMAL;
            fatigue -= States.NORMAL;
        }
        if(clickObject.name == "ShortTime"){
            stress += States.LOW;
            fatigue += States.LOW;
        }

        // Training의 경우
        if(clickObject.name == "FrequentT"){
            bloodSugar += States.HIGH;
            moisture += States.HIGH;
            stress += States.NORMAL;
        }
        if(clickObject.name == "NormalT"){
            bloodSugar -= States.NORMAL;
            moisture += States.HIGH;
        }
        if(clickObject.name == "RareT"){
            bloodSugar += States.HIGH;
            moisture -= States.HIGH;
        }
        
        // 수치 변동 확인 완료
        // print(muscleMass);
        // print(bloodSugar);
        // print(moisture);
        // print(stress);
        // print(fatigue);
    }

}
