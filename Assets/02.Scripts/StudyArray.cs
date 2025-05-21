using UnityEngine;

public class StudyArray : MonoBehaviour
{
    public int[] array1 = new int[4] {1005, 2262, 3566, 4673};

    void Start()
    {
        Debug.Log(array1.Length);
        for (int i = 0; i < array1.Length; i++)
        {
            Debug.Log(array1[i]);
        }

    }
}
