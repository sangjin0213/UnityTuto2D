using UnityEngine;
using namespaceA;
public class ScriptB : MonoBehaviour
{
    public ScriptA sA;
    void Start()
    {
        Debug.Log(sA.number2);
    }
}
