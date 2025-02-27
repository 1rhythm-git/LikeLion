using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _250226_Quest
{
    class Program
    {

        static int Length(string input)
        {
            return input.Length;
        }

        static int Max(int a, int b, int c)
        {
            int max = a;
            if(b>max)
            {
                max = b;
            }
            else if(c>max)
            {
                max = c;
            }
            return max;
        }

        static void Main(string[] args)
        {
            //Q9.세 개의 정수를 입력 받아 가장 큰 값을 반환하는 함수를 작성하세요.

            Console.Write("첫 번째 정수: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수: ");
            int c = int.Parse(Console.ReadLine());

            int max = Max(a, b, c);
            Console.WriteLine("가장 큰 값: "+ max);            
        }
    }
}
