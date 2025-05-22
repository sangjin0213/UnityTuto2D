using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    public Transform objTf;

    private void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        //objTf = GameObject.FindGameObjectWithTag("Player") <우변 출력이 GameObject 타입이라 좌변이랑 안맞음

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);
        objTf.gameObject.SetActive(false);
        //objTf : obj의 컴포넌트 transform을 봐라.     objTf.gameObject : objTf를 갖는 GameObject를 봐라.   
    }
}
