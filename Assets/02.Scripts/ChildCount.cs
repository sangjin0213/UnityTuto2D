using UnityEngine;

public class ChildCount : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        Debug.Log($"ť���� ù° �̸��� {cube.transform.GetChild(0).GetChild(1).name}");
    }
}
