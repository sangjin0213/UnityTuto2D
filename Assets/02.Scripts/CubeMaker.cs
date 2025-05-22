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
        //ť�� ����

        obj.GetComponent<MeshFilter>().mesh = msh;
        obj.GetComponent<MeshRenderer>().material = mat;
        //�޽�, ���׸��� ���� �����

        obj.AddComponent<BoxCollider>();
    }
}
