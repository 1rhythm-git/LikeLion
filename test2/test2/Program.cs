using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("시작하려면 엔터를 누르세요!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("○○○○○○○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●○○○○○○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●○○○○○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●○○○○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●○○○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●●○○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●●●○○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●●●●○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●●●●●○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●●●●●●○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("●●●●●●●●●●");
            Thread.Sleep(500);
            Console.Clear();
            

            Console.WriteLine("성공");*/


            int a;
            float b = 0.0f;

            Console.Write("a를 입력하세요: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b를 입력하세요: ");                     
            b = float.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}%");

        }
    }
}
