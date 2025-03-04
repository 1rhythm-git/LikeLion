using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _250304_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //플레이어 점수가 100점 이하면 "레벨업" 아니면 "노력필요" 출력

            /*int score = 101;

            if(score <= 100)
            {
                Console.WriteLine("레벨업");     
            }
            else
            {
                Console.WriteLine("노력필요");
            }*/

            //나이가 13세 미만이면 "어린이 출력", "13세 이상이고, 19세 이하면 "청소년", 그외 "성인을 출력하세요.

            /*Console.WriteLine("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());

            if(age < 13)
            {
                Console.WriteLine("어린이");
            }
            else if(age<=19)
            {
                Console.WriteLine("청소년");
            }
            else
            {
                Console.WriteLine("성인");
            }*/


            //if문과 switch문의 차이?
            //거의 유사하다

            /*string day = "토";

            switch(day)
            {
                case "월":
                case "화":
                case "수":
                case "목":
                case "금":
                    Console.WriteLine("평일입니다.");
                    break;
                case "토":
                case "일":
                    Console.WriteLine("주말입니다.");
                    break;
                default:
                    Console.WriteLine("????");
                    break;
            }*/

            //점수등급 (A, B, C, D)에 따라 메세지를 출력하세요
            //A= 최고, B=좋음, C=보통, D=탈락

            /*string score = Console.ReadLine();

            switch(score)
            {
                case "A":
                    Console.WriteLine("최고");
                    break;
                case "B":
                    Console.WriteLine("좋음");
                    break;
                case "C":
                    Console.WriteLine("보통");
                    break;
                case "D":
                    Console.WriteLine("탈락");
                    break;
            }*/

            //4계절
            //12~2월까지 겨울
            //3~5월까지 봄
            //6~8월까지 여름
            //9~11월까지 가을

            /*int month = int.Parse(Console.ReadLine());*/

            /*switch (month)
            {
                case 12: case 1: case 2: Console.WriteLine("겨울"); break;
                case 3: case 4: case 5: Console.WriteLine("봄"); break;
                case 6: case 7: case 8: Console.WriteLine("여름"); break;
                case 9: case 10: case 11: Console.WriteLine("가을"); break;
                default: Console.WriteLine("잘못 입력되었습니다"); break;
            }*/

            /*if(month ==12 || month == 1 || month ==2)
            {
                Console.WriteLine("겨울");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("봄");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("여름");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("가을");
            }
            else
            {
                Console.WriteLine("잘못입력되었습니다.");
            }*/

            //for문 : 어떤 특정 목적이나 대상을 정해놓고 그것을 위해 무언가를 수행하는 과정
            //정해진 횟수나 특정 조건을 만족하는 범위를 대상하는 반복 구조
            //for(초기화; 조건; 증감식;)
            //{반복될 내용}            
            /*for(int i=0; i<5; i++)
            {
                Console.WriteLine($"몬스터 소환 {i + 1}번째");
            }*/

            //1에서 10부터 숫자를 출력해보세요 for문 사용
            /*for(int i=0; i<10; i++)
            {
                Console.WriteLine(i+1);
            }

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }*/


            //1~10까지 합을 구하세요

            /*int sum = 0;

            for(int i=0; i<10; i++)
            {
                sum += i +1;
                Console.WriteLine(sum);
            }*/

            //숫자를 입력받아 입력받은 숫자의 구구단 단수를 출력하세요
            //예: 숫자2를 입력하면 2 x 1 = 2.........

            /*Console.WriteLine("숫자를 입력하시오: ");
            int a = int.Parse(Console.ReadLine());
            int x = 0;

            for(int i=0; i<9; i++)
            {   
                Console.WriteLine($"{a} x {i} = {a*i+1} ");
            }*/

            // * 출력
            // *
            // **
            // ***
            // ****
            //출력하기 (힌드: 가로로도 반복, 세로로도 반복)

            
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }
    }
}
