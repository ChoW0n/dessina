using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test_1 : MonoBehaviour
{
    //변수를 선언하는 방법은 타입과 변수명을 선언하고 세미콜론을 붙여준다.

    int test_int;   //정수를 할당할 때 int타입으로 변수를 선언하다.
    float test_float; //정수도 가능하지만 소수의 값을 저장할 때 float타입의 변수를 선언하다.
    string test_string; //문자열을 할당해줄 때 string타입의 변수를 선언해준다.
    bool test_bool; //true와 false의 값 즉 참과 거짓의 값을 할당 할 때 bool타입의 변수를 선언해준다.
    
    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/

    public int test_bool1;
    public int test_bool2;

    public bool test_while;
    private void Start()
    {
        //int 1 = 0은 반복을 시작하는 숫자, i < 10은 i 가 10보다 작을 때까지 반복, i++는 i를 1씩 증가
       /* for (int i = 0; i < 10;  i++)
        {
            Debug.Log(i);
        }*/

        
        //test_method(test_int2, test_int3);
        //test_int4 = test_method2(test_int2, test_int3);
    }
    //아래에 있는 건 전체 주석(Ctrl + Shift + / 를 누르면 된다)
    /*    void test_method(int a, int b) //return을 안해주는 함수 함수명 옆에 void로 선언해준다.
        {
            Debug.Log(a +b);
        }
        int test_method2(int a, int b) //return을 해주는 함수 옆에는 반환되는 값의 타입을 지정해준다.
        {
            return a + b;
        }*/
    private void Update()
    {
        //while문은 괄호 안에 있는 갑시 만족을 할 때 까지만 반복을 한다. 
        while (test_bool1 < 10)
        {
            Debug.Log(test_bool1);
        }
        //비교 연산자는
        //a > b a는 b보다 크다.
        //a < b a는 b보다 작다.
        //a == b a와 b는 같다.
        //a <= b a는 b와 같거나 작다.
        //a >= b a는 b와 같거나 크다.
        //a != b a와 b는 다르다.

        //논리연산자
        // && 그리고를 뜻함
        // || 또는
        // ! 아니다
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (test_bool1 < test_bool2)
            {
                Debug.Log("if 문 실행(참이다)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if 실행(참이다)");
            }
            else
            {
                Debug.Log("else 문 실행(모두 거짓이다)");
            }
            if (test_bool1 < test_bool2)
            {
                Debug.Log("if 문 실행(참이다)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if 실행(참이다)");
            }
            else
            {
                Debug.Log("else 문 실행(모두 거짓이다)");
            }
            if (test_bool1 < test_bool2)
            {
                Debug.Log("if 문 실행(참이다)");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("else if 실행(참이다)");
            }
            else
            {
                Debug.Log("else 문 실행(모두 거짓이다)");
            }
        }
    }
}
