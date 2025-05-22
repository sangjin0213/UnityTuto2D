using UnityEngine;

public class ChildCount : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        Debug.Log($"큐브의 첫째 이름은 {cube.transform.GetChild(0).GetChild(1).name}");
    }
}
