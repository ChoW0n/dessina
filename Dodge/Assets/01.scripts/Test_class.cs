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
        HyunTae = new Human();      //HumanŸ���� ��ü�� ��������(�ν��Ͻ�ȭ)
        HyunTae.age = 20;           //����� ���̸� ������
        HyunTae.name = "����";       //����� �̸��� ������
        Debug.Log("�̸� : " + HyunTae.name);
        Debug.Log("���� : " + HyunTae.age);
        HyunTae_1 = HyunTae;
        Debug.Log("�̸� : " + HyunTae_1.name);
        Debug.Log("���� : " + HyunTae_1.age);
        HyunTae_1.age = 15;
        Debug.Log("���� : " + HyunTae.age);
        Debug.Log("���� : " + HyunTae_1.age);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Human
{
    public string name;
    //private string name;        //private�� Human Ŭ���� ���ο����� ������ �����ϴ�
    public int age;             //public�� Human Ŭ���� �ܺο����� ������ �����ϴ�
    protected string test_protected;
    void Test_method()
    {
        name = "�̸�";
        age = 20; ;
    }
}

public class Test_Human2 : Human
{
    void Test_method()
    {
        test_protected = "�׽�Ʈ�� ���ڿ�"; //protected �� ����  �Ǿ��־ �ܺο��� ������ �Ұ��������� ��ӹ��� Ŭ�������� ������ �����ϴ�
    }
}