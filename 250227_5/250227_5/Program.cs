using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250227_5
{
    class Program
    {
        //15.C# 구조체
        // 클래스와 비슷하지만 값 타입(Value Type)이며 가볍고 빠르다
        // 주로 간단한 데이터 묶음을 만들때 사용


        struct Point
        {
            //struct Point는 X, Y 좌표 값을 저장하는 구조체
            //구조체는 클래스와 다르게 new 없이 사용 가능

            //public 어디서든 사용가능하게 권한
            //private 자신만 사용하게 하는 키워드
            public int X;
            public int Y;

            public Point()
            {

            }

            //생성자 정의:   처음 생성할 때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }


            public void Print()
            {
                Console.WriteLine($"좌표 : {X}, {Y}");
            }
        }

        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        static void Main(string[] args)
        {
            /*Point p;    //구조체 선언 (초기화 필요)

            p.X = 10;
            p.Y = 20;
            p.Print();

            Point p1 = new Point(5, 15);
            p1.Print();*/

            /*var rect = new Rectangle { Width = 5, Height = 4 };*/
            Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine($"Area : {rect.GetArea()}");

        }
    }
}
