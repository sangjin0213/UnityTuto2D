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
        Debug.Log("Ŭ����");
        Study_Class c1 = new Study_Class(10);       //c1����� �ٸ� ���� Study_Class ���� �� Study_Class�� 10 ����. =���� c1�� Study_Class �����ϰ� ��
        Study_Class c2 = c1;                        //c2�� c1����, �ٵ� c1�� ������. c1�� ����Ű�� Study_Class �� c2�� ����
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");
        c1.number = 100;                            //c1��, �� ���� 100���� �ٲ�(Study_Class�� ���ڸ� �ٲ�)
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");//�� ���� ���ÿ� ����Ű�� Study_Class�� �ٲ�. ���� ���� �� ��

        Debug.Log("����ü");
        Study_Struct s1 = new Study_Struct(10);      //s1����� ���ο� 10 ����.
        Study_Struct s2 = s1;                        //s2����� ���ο� s1�� ����.
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
        s1.number = 100;                             //s1�� �ٲ�. ������ s2�� �ƹ� ���� ����
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
    }
    
}