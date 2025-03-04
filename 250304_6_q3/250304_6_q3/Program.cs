using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250304_6_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*List<string> 생성");
            List<string> names = new List<string> {  };
            names.Add("사과");
            names.Add("바나나");
            names.Add("포도");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("*Queue<string> 생성");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");

            while(queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("*Stack<int> 생성");
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
