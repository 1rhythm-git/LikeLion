using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//단항 연산자
            int number = 5;
            Console.WriteLine(+number);
            Console.WriteLine(-number);

            bool flag = true;
            Console.WriteLine(!flag);   //논리 부정: false*/

            //~ 비트 반전
            //10    1010
            //      0101    4바이트    0000 0000 0000 0000 0000 0000 0000 1010

            /*int num = 10;
            int result = ~num;  //모든 비트 반전 : 1111 0101 결과 -11

            Console.WriteLine($"원래 값 : {num}");
            Console.WriteLine($"~ 연산자 적용 후 : {result}");*/


            //변환 연산자
            /*double pi = 3.14;
            int integerPi = (int)pi;

            Console.WriteLine(integerPi);*/

            /*float pi = 3.14f;
            int integerPi = (int)pi;

            Console.WriteLine(integerPi);*/

            /*int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;

            average = (float)sum / 3;

            Console.WriteLine("총점: "+sum);
            Console.WriteLine("평균: "+average);*/


            /*int a = 10, b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine((float)a / b);
            Console.WriteLine((float)a % b);*/

            /*//문자열 연결 연산자
            string firstName = "박";
            string lastName = "응창";
            Console.WriteLine($"{firstName}{lastName}");*/


            /*int a = 10, b = 5;
            a += b; //a = a + 5
            Console.WriteLine(a);
            a -= b; //a = a - 5
            Console.WriteLine(a);
            a *= b; //a = a * 5
            Console.WriteLine(a);
            a /= b; //a = a / 5
            Console.WriteLine(a);
            a %= b; //a = a % 5
            Console.WriteLine(a);*//*
            //-=, *=, /=, %=*/

            /*int b = 3;
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);*/


            /*int iKor = 0;
            int iEng = 0;
            int iMath = 0;
            int sum = 0;
            double average = 0.0f;

            Console.Write("국어점수: ");
            iKor = int.Parse(Console.ReadLine());
            Console.Write("영어점수: ");
            iEng = int.Parse(Console.ReadLine());
            Console.Write("수학점수: ");
            iMath = int.Parse(Console.ReadLine());

            int a = ~iKor;
            int b = ~iEng;
            int c = ~iMath;

            Console.Clear();

            sum = iKor + iEng + iMath;
            average = (double)sum / 3;


            Console.WriteLine($"국어점수: {iKor}");
            Console.WriteLine($"영어점수: {iEng}");
            Console.WriteLine($"수학점수: {iMath}");
            Console.WriteLine($"총점: {sum}");
            Console.WriteLine("평균: "+average.ToString("F2"));
            Console.WriteLine("---------------- ");
            Console.WriteLine("<~반전>");
            Console.WriteLine("~국어점수: "+a);
            Console.WriteLine("~영어점수: " + b);
            Console.WriteLine("~수학점수: " + a);

            Console.WriteLine("-----------------");
            int result = 0;
            Console.Write("값을 입력하세요: ");
            result = int.Parse(Console.ReadLine());

            Console.WriteLine(~result);*/


            /*//증감 연산자
            int b = 3;

            *//*//전위(해당 라인에서 증감) ++b,   후위(다음 라인에서 증감) b++
            Console.WriteLine("b의 값은: "+(b++));
            Console.WriteLine("b의 값은: " + (++b));*//*

            b--;
            Console.WriteLine($"b의 값은: " + (b--));
            Console.WriteLine($"b의 값은: " + b);*/


            /*int b = 3;
            Console.WriteLine($"b의 값은: {b++}");
            Console.WriteLine($"b의 값은: {++b}");

            b--;
            Console.WriteLine($"b의 값은: " + (b--));
            Console.WriteLine($"b의 값은: " + b);*/

            //관계 연산자, 두 값을 비교하여 관계를 평가한다.
            // == 같다    != 같지않다     a < b   c > d   <=  >=
            /*int x = 5, y = 10;
            Console.WriteLine(x < y);   //true
            Console.WriteLine(x == y);  //false
            Console.WriteLine(x != y);  //true
            Console.WriteLine(x >= y);  //fasle
            Console.WriteLine(x <= y);  //true*/


            //논리 연산자
            /*bool a = true, b = true;
            Console.WriteLine(a && b);  //AND: 둘 다 true일 경우 참, 아니면 거짓
            //AND   :   1 : 1   t [O]
            //      :   1 : 0   f [X]
            //      :   0 : 1   f [X]
            //      :   0 : 0   f [X]
            Console.WriteLine(a || b);  //OR:   둘 중 하나가 true일 경우 참, 아니면 거짓
            //OR   :   1 : 1   t [O]
            //     :   1 : 0   t [O]
            //     :   0 : 1   t [O]
            //     :   0 : 0   f [X]
            Console.WriteLine(!a);
            //NOT  :   1 : 1   t [O]    //NOT:  true일 경우 거짓, 아니면 참
            //     :   1 : 0   f [X]
            //     :   0 : 1   f [X]
            //     :   0 : 0   t [O]*/

            /*bool a = false, b = false;
            Console.WriteLine(!a); // NOT: False*/

            //비트 연산자
            /*int x = 5;
            int y = 3;

            Console.WriteLine(x & y);   //AND: 1(0001)
            Console.WriteLine(x | y);   //OR:  7(0111)
            Console.WriteLine(x ^ y);   //XOR: 6(0110)
            Console.WriteLine(~x);      //NOT: -6*/


            //시프트 연산자 -> 데이터 압축 등에 활용
            /*int value = 4;
            Console.WriteLine(value<<1);    //왼쪽으로 이동: 8 (1000)
            Console.WriteLine(value>>1);    //오른쪽으로 이동: 2 (0010)*/


            //기타 연산자
            //?: 삼항 연산자, 조건문을 간단히 표현
            //is: 객체가 특정 형식인지 확인
            //??: null 병합 연산자

            /*int a = 10, b = 20;
            int max = (a > b) ? a : b;  //삼항 연산자
            Console.WriteLine(max);*/



            /*Console.Write("1 or 2의 값을 입력하세요: ");
            int key = int.Parse(Console.ReadLine());
            string str;
            str = (key == 1) ? "문이열렸습니다." : "문이 잠겼습니다.";

            Console.WriteLine(str);*/


            //연산자 우선순위
            /*int result = (10 + 2) * 5;
            Console.WriteLine(result);*/


            //제어문
            //순차실행, 조건분기, 반복실행 등이 포함

            //순차문: 순서대로 실행하기
            /*Console.WriteLine("1단계 시작");
            Console.WriteLine("2단계 시작");
            Console.WriteLine("3단계 시작");*/


            //조건문: if문과 가지치기
            /*int score = 90;
            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("90점 미만");
            }*/

            /*int num = 20;
            if (num > 15)
            {
                Console.WriteLine("확인");
            }
            else
            {
                Console.WriteLine("취소");
            }*/

            /*Console.Write("학점을 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if(score>=80)
            {
                Console.WriteLine("B학점");
            }
            else if(score>=70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }*/

            /*Console.Write("아이디를 입력하세요: ");
            string GameID = Console.ReadLine();
            if(GameID == "박응창")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else 
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }*/


            //1단계
            //가지고 있는 소지금을 입력하세요 :
            //0~100 무한의대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6
            //601이상 전설검 +7

            //캐릭터 이름
            //무기이름
            //공격력 : 100 + 1

            String name = "멋사검존";
            String sword = default;
            int Att = 0;

            Console.Write("가지고 있는 소지금을 입력하세요: ");
            int Gold = int.Parse(Console.ReadLine());
            if (Gold >= 0 && Gold <= 100)
            {
                sword = "무한의대검";
                Att = 1;
            }
            else if (Gold > 101 && Gold <= 200)
            {
                sword = "카타나";
                Att = 2;
            }
            else if (Gold > 201 && Gold <= 300)
            {
                sword = "진은검";
                Att = 3;
            }
            else if (Gold > 301 && Gold <= 400)
            {
                sword = "집판검";
                Att = 4;
            }
            else if (Gold > 401 && Gold <= 500)
            {
                sword = "엑스칼리버";
                Att = 5;
            }
            else if (Gold > 501 && Gold <= 600)
            {
                sword = "유령검";
                Att = 6;
            }
            else if (Gold > 601)
            {
                sword = "전설검";
                Att = 7;
            }
            else
            {

            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"캐릭터: {name}");
            Console.WriteLine($"무기: {sword}");
            Console.WriteLine($"공격력: 100 + {Att}");




        }
    }
}
