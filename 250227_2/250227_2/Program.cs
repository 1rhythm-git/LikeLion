﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는 것을 방지하기 위해 사용된다.
//

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요 !MyNamespace의 MyClass입니다.");
        }
    }
}

namespace _250227_2
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("ㅎㅎㅎㅎㅎㅎ");
        }
        static void Main(string[] args)
        {
            SayHello();
            dev1.MyClass.SayHello();

        }
    }
}
