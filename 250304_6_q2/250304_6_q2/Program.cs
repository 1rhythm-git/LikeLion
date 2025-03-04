using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250304_6_q2
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.Write("입력: ");
                string input = Console.ReadLine();

                try
                {
                    int num = int.Parse(input); // 값 입력
                    Console.WriteLine($"출력: {num}"); // 값 출력 
                }
                catch(FormatException ex)
                {
                    Console.WriteLine($"Format Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("<완료> \n");
                }
            }

        }
    }
}
