﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306_4
{
    class MyResource
    {
        //소멸자
        ~MyResource()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyResource r = new MyResource();
            //GC(가비지컬렉터)에 의해 나중에 소멸자 호출

            //가비지 컬렉션은 더이상 참조되지 않는 객체를 정리합니다.
        }
    }
}
