using UnityEngine;

public class Study_Class
{
    public int number;

    public Study_Class(int number)
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
}

public class Study_ClassStruct : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("클래스");
        Study_Class c1 = new Study_Class(10);       //c1만들고 다른 곳에 Study_Class 만든 뒤 Study_Class에 10 넣음. =으로 c1이 Study_Class 참조하게 함
        Study_Class c2 = c1;                        //c2는 c1참조, 근데 c1은 껍데기. c1이 가리키는 Study_Class 를 c2도 참조
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");
        c1.number = 100;                            //c1아, 네 숫자 100으로 바꿔(Study_Class의 숫자를 바꿔)
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");//즉 둘이 동시에 가리키던 Study_Class가 바뀜. 둘이 같은 말 함

        Debug.Log("구조체");
        Study_Struct s1 = new Study_Struct(10);      //s1만들고 내부에 10 넣음.
        Study_Struct s2 = s1;                        //s2만들고 내부에 s1꺼 넣음.
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
        s1.number = 100;                             //s1꺼 바뀜. 별개인 s2는 아무 영향 없음
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
    }
    
}