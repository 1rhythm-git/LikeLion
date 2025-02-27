using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 계산기_만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // 계속 실행
            {
                Console.WriteLine("간단한 계산기 (종료하려면 'q' 입력)");

                Console.Write("첫 번째 숫자를 입력하세요: ");
                string input1 = Console.ReadLine();
                if (input1 == "q") break; // 'q' 입력 시 종료

                Console.Write("연산자를 입력하세요 (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("두 번째 숫자를 입력하세요: ");
                string input2 = Console.ReadLine();
                if (input2 == "q") break;

                // 숫자로 변환
                if (!double.TryParse(input1, out double num1) || !double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("올바른 숫자를 입력하세요.");
                    continue; // 다시 루프 실행
                }

                double result = 0;
                switch (op)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("0으로 나눌 수 없습니다.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("잘못된 연산자입니다.");
                        continue;
                }

                Console.WriteLine($"결과: {result}");
            }

        }
    }
}