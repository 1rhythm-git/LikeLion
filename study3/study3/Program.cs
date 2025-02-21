using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            //캐릭터
            //hp : 100
            //att : 56.7
            //캐릭터 이름 : ??
            //등급 : S

            int HP = 100;
            double pi = 56.7;
            string name = "박응창";
            char grade = 'S';

            Console.WriteLine("캐릭터");
            Console.WriteLine("체력 : "+HP);
            Console.WriteLine("공격력 : "+pi);
            Console.WriteLine("캐릭터 이름 : "+name);
            Console.WriteLine("등급 : "+grade);


        }
    }
}
