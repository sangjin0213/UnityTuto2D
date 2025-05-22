using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prf;

    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    void Start()
    {
        CreateA();

        Destroy(destroyObj, 3.0f);
    }

    public void CreateA()
    {
        GameObject obj = Instantiate(prf, pos, rot);
        obj.name = "ºÐ½Å1";
    }
}
