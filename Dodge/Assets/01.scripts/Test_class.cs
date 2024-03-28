using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Test_class : MonoBehaviour
{
    public Human HyunTae;
    public Human HyunTae_1;

    // Start is called before the first frame update
    void Start()
    {
        HyunTae = new Human();      //Human타입의 객체를 만들어줬다(인스턴스화)
        HyunTae.age = 20;           //사람의 나이를 정해줌
        HyunTae.name = "현태";       //사람의 이름을 정해줌
        Debug.Log("이름 : " + HyunTae.name);
        Debug.Log("나이 : " + HyunTae.age);
        HyunTae_1 = HyunTae;
        Debug.Log("이름 : " + HyunTae_1.name);
        Debug.Log("나이 : " + HyunTae_1.age);
        HyunTae_1.age = 15;
        Debug.Log("나이 : " + HyunTae.age);
        Debug.Log("나이 : " + HyunTae_1.age);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Human
{
    public string name;
    //private string name;        //private는 Human 클래스 내부에서만 접근이 가능하다
    public int age;             //public은 Human 클래스 외부에서도 접근이 가능하다
    protected string test_protected;
    void Test_method()
    {
        name = "이름";
        age = 20; ;
    }
}

public class Test_Human2 : Human
{
    void Test_method()
    {
        test_protected = "테스트용 문자열"; //protected 로 선이  되어있어서 외부에선 접근이 불가능하지만 상속받은 클래스에선 접근이 가능하다
    }
}