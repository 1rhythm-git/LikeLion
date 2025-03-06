using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306_5
{
    

    class Program
    {
        //ref 포인터 개념 참조
        //메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }

        //out은 반환이 여러개일때 유용하다
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = 10;
            y = 20;
        }


        static void Main(string[] args)
        {
            /*int a = 10;
            Increase(ref a);
            Console.WriteLine("A의 값 : " + a);*/

            int a = 10;
            int b = 20;
            int x, y;
            OutFunc(a, b, out x, out y);

            Console.WriteLine("x: " + x + " y: "+y);

        }
    }
}
