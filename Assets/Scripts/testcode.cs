using System;
using UnityEditor.Build.Player;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    
    class Human //클래스 멤버 정의
        //필드 - 각 필드에 맞는 자료형을 선택, 변수형태로 정의
    {
        public string name = "AAAA";
        public float height = 160f;
        public int age = 20;
    }

    //메서드 - 타 언어에서 함수로 정의
    //인수(입력값) 받음 > 처리 > 반환값 반환
    //매개변수 - 전달되는 입력값을 받아줌

    public int PlusSomething(int someting) //메서드 머리
    {
        return (someting + 1);
    }


    //int one = 1;
    //char a = 'a';
    //string myname = "ALMAPLUS";

    //bool booltrue = true;
    //bool boolfalse = false;

    //object anything = true;

    void Start()
    {
        //Debug.Log(one);
        //Debug.Log(a);
        //Debug.Log(myname);
        //Debug.Log(booltrue);
        //Debug.Log(boolfalse);
        //Debug.Log(anything);
        //Debug.Log("Hello World!");
    }

    void Update()
    {
        //Debug.Log("Update");
    }
}
