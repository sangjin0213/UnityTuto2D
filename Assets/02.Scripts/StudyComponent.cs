using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    public Transform objTf;

    private void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        //objTf = GameObject.FindGameObjectWithTag("Player") <�캯 ����� GameObject Ÿ���̶� �º��̶� �ȸ���

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);
        objTf.gameObject.SetActive(false);
        //objTf : obj�� ������Ʈ transform�� ����.     objTf.gameObject : objTf�� ���� GameObject�� ����.   
    }
}
