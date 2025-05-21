using UnityEngine;

public class WantCube : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        obj = GameObject.Find("Cube");
        obj.name = "Å¥ºê";
    }
}
