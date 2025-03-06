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

        static void Main(string[] args)
        {
            int a = 10;
            Increase(ref a);

            Console.WriteLine("A의 값 : " + a);
        }
    }
}
