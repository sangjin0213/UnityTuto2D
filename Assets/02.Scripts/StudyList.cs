using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StudyList : MonoBehaviour
{
    public List<int> list1 = new List<int>();

    void Start()
    {
        list1.Add(10);
        list1.Add(20);
        list1.Add(30);
        list1.Add(40);

        Debug.Log(list1.Count);
        for (int i = 0; i < 4; i++)
        {
            Debug.Log(list1[i]);       
        }
    }
}
