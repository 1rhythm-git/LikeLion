﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250227_8
{


    class Program
    {
        struct Student
        {
            public string Name; //학생이름
            public int iKor;    //국어
            public int iEng;    //영어
            public int iMath;   //수학

            //학생 정보를 출력하는 함수

            public void Print()
            {
                Console.WriteLine($"{Name,-10}\t{iKor}\t{iEng}\t{iMath}");
            }
        }
        

        static void Main(string[] args)
        {
            //구조체를 이용해서
            //학생 3명의 이름 성적을 받고 국어, 영어, 수학
            //출력하시오.

            //이름     국어   영어    수학
            //홍길동   100     80      70
            //임꺽정   90      10      20
            //고길동   20      15      70

            //학생 배열 선언
            Student[] students = new Student[3];

            for(int i=0; i<students.Length; i++)
            {
                Console.WriteLine("학생성적을 입력하세요.");
                Console.WriteLine("학생이름 : ");
                students[i].Name = Console.ReadLine();
                Console.WriteLine("국어 : ");
                students[0].iKor = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 : ");
                students[0].iEng = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 : ");
                students[0].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름           국어    영어    수학");

            foreach(Student std in students)
            {
                std.Print();
            }

        }


    }
}
