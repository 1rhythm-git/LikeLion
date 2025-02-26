
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _250226
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            // 0부터 시작한다.

            /*int[] num = new int[3]; //3개 메모리 할당

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]);
            }*/


            //배열 선언의 방식과 종류
            /*int[] numbers = { 1, 2, 3 };    //간단한 선언과 초기화
            int[] numbers2 = new int[3];    //크기만 지정
            int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

            for(int i =0; i<3; i++)
            {
                Console.WriteLine(numbers3[i]);
            }*/

            /*string[] fruits = { "사과", "바나나", "오렌지" };

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/


            //3명의
            //국어, 영어, 수학 점수를 입력 받고
            //총점과 평균을 출력하세요.

            /*int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMath = new int[3];

            int[] sum = new int[3];
            float[] aver = new float[3];

            //학생입력받기
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("학생 성적입력하세요 : ");
                Console.Write("국어: ");
                iKor[i] = int.Parse(Console.ReadLine());
                Console.Write("영어: ");
                iEng[i] = int.Parse(Console.ReadLine());
                Console.Write("수학: ");
                iMath[i] = int.Parse(Console.ReadLine());

                sum[i] += iKor[i] + iEng[i] + iMath[i];

                aver[i] = (float)sum[i] / 3;

            }


            //출력
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + "번학생");
                Console.WriteLine($"국어: {iKor[i]} 영어: {iEng[i]} 수학: {iMath[i]} ");
                Console.WriteLine("총점: " + sum[i]);
                Console.WriteLine("평균: " + aver[i].ToString("F2"));
            }*/



            //1차원 배열
            /*int[] scores = new int[3];

            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;

            for(int i = 0; i<scores.Length; i++)    // .Length는 배열의 길이 관계없이 가져온다
            {
                Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            }*/


            /*double value = 123.456789;
            //소수점 자릿수 설정하는 포맷
            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소숫점둘째자리 : {value:F4}");
            Console.WriteLine(String.Format("소수점 둘째자리: {0:F2}", value));
            
            //소수점 없이 정수 출력
            Console.WriteLine(value.ToString("F0"));*/

            //천단위 쉼표
            /*double value = 876478923.12323;
            Console.WriteLine(value.ToString("N2"));*/


            //2차원 배열 선언
            /*int[,] matrix = new int[2, 3]
            {
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            };

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }*/


            //가변배열
            /*int[][] matrix = new int[2][];

            matrix[0] = new int[3];
            matrix[1] = new int[4];

            //값 입력
            matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;

            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;
            matrix[1][3] = 7;

            //출력
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }*/

            //6.가변배열
            /*Console.WriteLine("가변배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 4, 5, 6 };
            jaggedArray[2] = new int[] { 7  };

            for(int i =0; i<jaggedArray.Length; i++)
            {
                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");*/


            //스왑
            /*int a = 10;
            int b = 20;
            int t = 0;

            t = a;
            a = b;
            b = t;

            Console.WriteLine("a : " + a + " b : " + b);*/

            //빙고게임 만들기

            /*int[] iArray = new int[25];

            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }

            Random rand = new Random();
            //셔플
            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;

            }

            int input = 0;
            int iBingo = 0;
            int iCount = 0;
            
            while (true)
            {
                Console.Clear();
                

                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0)   //0일 경우 체크
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("빙고 숫자 :" + iBingo);
                Console.Write("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;

                for(int i=0; i<25; i++)
                {
                    if (iArray[i] == input)
                    { 
                        iArray[i] = 0;
                        break;                  
                    }
                }

                //방고 체크 로직
                //가로 체크
                for(int i=0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (iArray[i*5+j] == 0)
                        {
                            ++iCount;
                        }
                        if (iCount == 5)
                        { 
                            ++iBingo; 
                        }
                            
                    }
                    iCount = 0;
                }                

                //세로 체크
                for(int i=0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (iArray[i+5*j] == 0)
                        {
                            ++iCount;
                        }
                        if(iCount == 5 )
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }


                //우측 대각선
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for(int i = 0; i<5; i++)
                {
                    if (iArray[i*4+4] ==0)
                    {
                        ++iCount;
                    }

                    if(iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
                //좌측 대각선
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++iCount;
                    }

                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;

                if(iBingo >=5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }
            }*/


            //2차 배열
            /*int[,] board = new int[5, 5]; //5x5 빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //랜덤 섞기(Fisher-Yates Shuffle)
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            }


            //2차원 배열로 변환
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }


                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }


                //대각선 체크 (왼쪽위 ->오른쪽 아래)

                bool diag1Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;


                //대각선 오른쪽위 ->왼쪽아래
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;


                if (diag2Bingo) bingoCount++;

            }

            Console.WriteLine("빙고 5개 완성! 게임종료");*/



        }
    }
}
