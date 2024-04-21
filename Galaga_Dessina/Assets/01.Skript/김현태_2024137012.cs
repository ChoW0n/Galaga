using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class 김현태_2024137012 : MonoBehaviour
{
    public int currentMonth;
    // Start is called before the first frame update
    void Start()
    {
        //3-1 홀수 짝수 구분
        int inputNumber = 2022;

        if (inputNumber % 2 == 0)
        {
            Debug.Log("짝수입니다.");
        }
        //3-2 오전과 오후 구분
        Debug.Log(DateTime.Now.Year);
        Debug.Log(DateTime.Now.Month);
        Debug.Log(DateTime.Now.Day);
        Debug.Log(DateTime.Now.Hour);
        Debug.Log(DateTime.Now.Minute);
        Debug.Log(DateTime.Now.Second);

        if (DateTime.Now.Hour < 12)
        {
            Debug.Log("오전입니다.");
        }
        if (DateTime.Now.Hour > 12)
        {
            Debug.Log("오후입니다.");
        }
        //3-3 홀수 짝수 구분
        int inputNumber2 = 2021;
        
        if (inputNumber2 % 2 == 0)
        {
            Debug.Log("짝수입니다.");
        }
        else
        {
            Debug.Log("홀수입니다.");
        }
        //3-4 오전괴 오후 구분
        if (DateTime.Now.Hour < 12)
        {
            Debug.Log("오전입니다.");
        }
        if (DateTime.Now.Hour > 12)
        {
            Debug.Log("오후입니다.");
        }
        //3-5 중첩 조건문 활용
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("아침 먹을 시간입니다.");
        }
        else
        {
            if (DateTime.Now.Hour < 15)
            {
                Debug.Log("점심 먹을 시간입니다.");
            }
            else
            {
                Debug.Log("저녁 먹을 시간입니다.");
            }
        }
        //3-6 if else if 조건문 활용
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("아침 먹을 시간입니다.");
        }
        else if (DateTime.Now.Hour < 15)
        {
            Debug.Log("점심 먹을 시간입니다.");
        }
        else
        {
            Debug.Log("저녁 먹을 시간입니다.");
        }
        //Page11 if문
        //학점 변수
        double score = 3.6;
        if (score == 4.5)
            Debug.Log("신");
        else if (4.2 <= score)
            Debug.Log("교수님의 사랑");
        else if (3.5 <= score)
            Debug.Log("현 체제의 수호자");
        else if (2.8 <= score)
            Debug.Log("일반인");
        else if (2.3 <= score)
            Debug.Log("일탈을 꿈꾸는 소시민");
        else if (1.75 <= score)
            Debug.Log("오락문화의 선구자");
        else if (1.0 <= score)
            Debug.Log("불가축 천민");
        else if (0.5 <= score)
            Debug.Log("자벌레");
        else if (0 < score)
            Debug.Log("플랑크톤");
        else
            Debug.Log("시대를 앞서가는 혁명의 씨앗");

        //3-7 Switch 조건문 활용
        //아래 if-else 문으로 되어있는 조건문을 switch문으로
        int inputNumver3 = 2021;
        switch (inputNumver3 % 2)
        {
            case 0:
                Debug.Log("짝수 입니다.");
                break;
            case 1:
                Debug.Log("홀 수 입니다.");
                break;
        }
        //3-8 변형예제
        currentMonth = 4;
        switch (currentMonth)
        {
            case 12:
            case 1:
            case 2:
                Debug.Log("겨울입니다.");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("봄입니다.");
                break;
            case 6:
            case 7:
            case 8:
                Debug.Log("여름입니다.");
                break;
            case 9:
            case 10:
            case 11:
                Debug.Log("가을입니다.");
                break;
            default:
                Debug.Log("잘못된 월을 입력했습니다.");
                break;
        }
        //3-9 삼항 연산자
        //변수 선언
        string input = "-52273";
        int number2 = int.Parse(input);

        Debug.Log(number2 > 0 ? "자연수입니다." : "자연수가 아닙니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
