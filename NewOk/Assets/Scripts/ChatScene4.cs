using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatScene4 : MonoBehaviour
{
    public Text ChatText; // 실제 채팅이 나오는 텍스트
    //public Text CharacterName; // 캐릭터 이름이 나오는 텍스트


    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = "";

    bool isButtonClicked = false;

    void Start()
    {
        StartCoroutine(TextTyping());
    }

    void Update()
    {
        foreach (var element in skipButton) // 버튼 검사
        {
            if (Input.GetKeyDown(element))
            {
                isButtonClicked = true;
            }
        }
    }

    
    IEnumerator NormalChat(string narration)
    {
        int a = 0;
        //CharacterName.text = narrator;
        writerText = "";

        //텍스트 타이핑 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //키를 다시 누를 떄 까지 무한정 대기
        while (true)
        {
            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextTyping()
    {
        yield return StartCoroutine(NormalChat("\"이러다가 우리 다 망해~~\" \n우리들의 목표는 건강한 자연사! \n지금부터 장기들의 눈물 겨운 \'건강한 자연사 프로젝트\'가 시작된다."));
    }
}