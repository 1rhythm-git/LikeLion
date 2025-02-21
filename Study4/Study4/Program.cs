using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//문자열
            string greeting;   //문자열 변수를 선언
            greeting = "Hello, World!";  //변수에 값을 저장

            //변수의 값을 사용
            Console.WriteLine(greeting);    //출력 : Hello, World!*/


            /*//변수 선언과 초기화를 한 번에 수행
            int score = 100;    //정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5;  //실수형 변수 선언과 초기화
            string city = "Seoul";  //문자열 변수 선언과 초기화

            //변수 출력
            Console.WriteLine("점수 = "+score);
            Console.WriteLine("온도 = "+temperature);
            Console.WriteLine("도시 = "+city);*/


            /* //같은 데이터 타입의 변수를 쉼표로 구분해 한 번에 선언
             int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화

             Console.WriteLine("x = "+x);
             Console.WriteLine("y = "+y);
             Console.WriteLine("z = "+z);*/

            /*//상수: 값을 변경할 수 없는 변수
            const double Pi = 3.14159;  //상수 Pi 선언 및 초기화
            const int MaxScore = 100;   //정수형 상수 선언

            //출력
            Console.WriteLine("Pi = "+Pi);  //출력 Pi
            Console.WriteLine("MaxScore = "+MaxScore);    //출력 MaxScore*/

            //

            /*int a = 16755, b = 78103, c = 36, d = 1017, e = 41, f = 611, g = 22, h = 39;

            Console.WriteLine("공격력 = "+a);
            Console.WriteLine("최대 생명력 = "+b);
            Console.WriteLine(" ");
            Console.WriteLine("치명 = "+c);
            Console.WriteLine("특화 = "+d);
            Console.WriteLine("제압 = "+e);
            Console.WriteLine("신속 = "+f);
            Console.WriteLine("인내 = "+g);
            Console.WriteLine("숙련 = "+h);*/

            /*//숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integerNum = 10;    //정수 데이터
            float floatNum = 3.14f; //단정밀도 실수
            double doubleNum = 3.14159; //배정밀도 실수

            Console.WriteLine(integerNum);  //출력 10
            Console.WriteLine(floatNum);    // 출력 3.14
            Console.WriteLine(doubleNum);   // 출력 3.14159*/


            /*//정수 데이터 형식: 소수점이 없는 숫자를 표현
            int intValue = -100;    //4바이트 크기의 정수
            long longValue = 1234567890L;   //8바이트 크기의 정수

            Console.WriteLine(intValue);    //출력: -100
            Console.WriteLine(longValue);   //출력: 1234567890*/


            //1비트   0과1로 구분
            //8비트   1바이트


            /*//부호 있는 정수: 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50;   //1바이트 크기
            short signedShort = -32000; //2바이트
            int signedInt = -200000000; //4바이트

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);*/


            /*//부호없는 정수 데이터 형식
            byte unsignedByte = 255;    //1바이트 크기
            ushort unsignedShort = 65000;  //2바이트 크기
            uint unsignedInt = 4000000000;  //4바이트 크기

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);*/


            /*//실수 데이터 형식
            float singlePrecision = 3.14f;
            double doublePrecision = 3.1415926535;
            decimal decimalPrecision = 3.1415926535897932384626433833m;

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(decimalPrecision);*/


            /*//숫자 형식의 리터럴 값에 접미사 붙이기
            int integerValue = 100;
            long longValue = 100l;
            float floatValue = 3.14f;
            double doubleValue = 3.14;
            decimal decimalValue = 3.14m;

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);*/


            /*//문자 데이터 형식
            char letter = 'A';
            char symbol = '#';
            char number = '9';

            Console.WriteLine("letter = "+letter);
            Console.WriteLine("symbol = "+symbol);
            Console.WriteLine("number = "+number);*/


            //string 형식: 여러 문자를 저장
            string greeting = "Hello World";
            string name = "Alice";

            /*Console.WriteLine(greeting);
            Console.WriteLine(name);*/

            /*Console.Write(greeting);
            Console.Write(name);*/
            /*
                        Console.Write(greeting +" "+ name);*/


            /*//bool형식    :   참(true) = 1     거짓(false) = 0
            bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);*/


            /*//const: 변하지 않는 값을 정의
            const double Pi = 3.14159;
            const int MaxScore = 100;

            Console.WriteLine(Pi);
            Console.WriteLine(MaxScore);*/


            /*//닷넷 형식 : 기본 형식의 닷넷 표현
            System.Int32 number = 123;
            System.String text = "Hello";
            System.Boolean flag = true;

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(flag);*/


            //int 래퍼 형식의 메서드 활용
            int number = 123;
            string numberAsString = number.ToString();


            //bool 래퍼 형식의 메서드 활용
            bool flag = true;
            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);


        }
    }
}
