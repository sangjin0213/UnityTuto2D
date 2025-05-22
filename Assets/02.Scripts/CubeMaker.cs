using UnityEngine;

public class CubeMaker : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        CreateCube();
    }

    public void CreateCube()
    {
        obj = new GameObject("Cube_newbie");

        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<BoxCollider>();
        //큐브 형성

        obj.GetComponent<MeshFilter>().mesh = msh;
        obj.GetComponent<MeshRenderer>().material = mat;
        //메쉬, 머테리얼 소켓 만들기

        obj.AddComponent<BoxCollider>();
    }
}
