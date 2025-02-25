using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;  //커서 숨기기

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("┃                             대장장이 키우기                                 ┃");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("┃                                                                             ┃");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);

            Console.Clear();

            for(int x = 0; x<30; x++)   //0~29이동
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.WriteLine("◎");
                Thread.Sleep(100);
            }

        }
    }
}
