using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250305_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // List
            // Dictionary(키, 밸류)
            // foreach
            // 인덱스 접근x
            // 반복횟수 지정x for문은 가능
            /*Dictionary<string, int> test = new Dictionary<string, int>();
            test.Add("키1", 0);
            test.Add("키2", 0);
            test.Add("키3", 0);
            test.Add("키4", 0);

            foreach(var data in test)
            {
                Console.WriteLine(data.Key);
            }

            for (int i=0; i<5; i++)
            {
                //인덱스가 i
            }*/

            // 구구단을 2단 ~ 9단 출력



            /*for(int i=1; i<=9; i++)
            {
                for(int j=2; j<=9; j++)
                {
                    
                    Console.Write($"{j} x {i} = {i*j}\t");
                }
                Console.WriteLine();
            }*/

            // while()
            // 조건 동안만 반복
            // 일정 조건을 충족하면 break

            //while문으로 1~5까지 숫자를 출력하고 종료하는 알고리즘

            /*int num = 0;

            while(num <=4)
            {
                num++;
                Console.WriteLine(num);
            }*/

            // 1에서 10까지의 합 구하기

            /*int sum = 0;
            int num = 1;
            while(num <=10)
            {
                sum += num;
                num++;                
            }
            Console.WriteLine("합:" + sum);*/

            // 가위, 바위, 보 게임 만들기
            // if, switch, while문을 사용
            // 1~3번 선택, 상대는 랜덤으로 가위바위보
            // 승리, 무승부, 패배


            /*Random random = new Random();

            while (true)
            {
                Console.WriteLine("========가위바위보 게임========");
                Console.WriteLine("1:가위, 2:바위, 3:보");
                Console.WriteLine("숫자를 입력하세요 :) (0번을 입력하면 게임이 종료됩니다)");

                string input = Console.ReadLine();
                int useChoice;
                try
                {
                    useChoice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.\n");
                    continue;
                }

                if (useChoice == 0) break;

                if (useChoice < 1 || useChoice > 3)
                {
                    Console.WriteLine("1,2,3중 하나의 숫자를 입력하세요\n");
                    continue;
                }


                int computerChoice = random.Next(1, 4);



                string userMove = "";
                //if (useChoice == 1) userMove = "가위";
                //else if (useChoice == 2) userMove = "바위";
                //else if (useChoice == 3) userMove = "보";

                string computerMove = "";
                //if (computerChoice == 1)
                //{
                //    computerMove = "가위";
                //    Console.WriteLine(computerMove);
                //}
                //else if (computerChoice == 2) computerMove = "바위";
                //else if (computerChoice == 3) computerMove = "보";

                switch (useChoice)
                {
                    case 1: userMove = "가위"; break;
                    case 2: userMove = "바위"; break;
                    case 3: userMove = "보"; break;
                }

                switch (computerChoice)
                {
                    case 1: computerMove = "가위"; break;
                    case 2: computerMove = "바위"; break;
                    case 3: computerMove = "보"; break;
                }

                Console.WriteLine($"나 : {userMove}, 컴퓨터 : {computerMove}");

                if (useChoice == computerChoice)
                {
                    Console.WriteLine("비겼슴둥...\n");
                }
                else if ((useChoice == 1 && computerChoice == 3) ||
                        (useChoice == 2 && computerChoice == 1) ||
                        (useChoice == 3 && computerChoice == 2))
                {
                    Console.WriteLine("이겼슴둥!!!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("졌슴둥......ㅠㅠ\n");
                }*/


                // 컴퓨터가 랜덤하게 1~100까지 숫자를 10번 안에 맞추기

            Random rand = new Random();
            int number = rand.Next(1, 101);

            int userChoice = 0;
            int computerChoice = 0;
            int maxCount = 10;

            Console.WriteLine("숫자맞추기");
            Console.WriteLine("1~100까지 숫자를 10번안에 맞춰라");

            while(true)
            {
                string input = Console.ReadLine();
                try
                {
                    userChoice = int.Parse(input);
                }
                catch(FormatException)
                {
                    Console.WriteLine("올바른 숫자를 입력하세요\n");
                    continue;
                }
                choiceCount++;

                //결과 값 조건문 시작
                if(userChoice < number) Console.WriteLine("Down");
                else if(userChoice)
            }

            


        }
    }
}
