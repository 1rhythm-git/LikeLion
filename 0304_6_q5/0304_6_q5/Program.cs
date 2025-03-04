using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304_6_q5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("1~10까지 짝수 출력: ");
            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            for(int i =0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("\n1~10까지 합: ");
            Console.WriteLine(sum);
        }
    }
}
