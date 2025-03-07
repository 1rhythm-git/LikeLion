using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int형 정수를 5번 입력받아 1차원 배열에 저장후
            //배열에 저장된 모든 값의 합을 계산하는 알고리즘

            /*int[] numbers = new int[5];

            Console.WriteLine("정수 5개 입력: ");
                        
            for(int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine($"숫자 {i+1} :");
                numbers[i] = int.Parse(Console.ReadLine());
                
            }
            int sum = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"합: {sum}");*/

            //1차원 배열에 저장된 정수 {12, 45, 7, 34, 22)의
            //최대 값과 최소 값을 각각 출력

            /*int[] num = new int[] { 12, 45, 7, 34, 22 };
            
            //최대값의 기준을 정하자
            int max = num[0];
            //최소값의 기준을 정하자
            int min = num[0];

            for(int i =1; i<num.Length; i++)
            {
                if(max < num[i])
                {
                    max = num[i];
                }
                else if(min > num[i])
                {
                    min = num[i];
                }
            }
            Console.WriteLine($"최대값은 {max}, 최소값은 {min}");*/

            //List<int> == int[] 차이점
            //int[] number = new int[길이];
            //List<형식> 길이는 가변적으로 원하는만큼 사용할 수 있다.

            //1차원 배열에 저장된 정수를 역순으로 출력
            //1,2,3,4,5

            /*List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);

            Console.WriteLine("배열요소를 역순으로 출력합니다 : ");
            for(int i = num.Count -1; i>=0; i--)
            {
                Console.WriteLine(num[i] + " ");
            }
            Console.WriteLine();*/

            //2차원배열
            //길이 지정
            /*int[,] array =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9}
            };
            for(int y=0; y<3; y++)
            {
                for(int x=0; x<3; x++)
                {
                    Console.Write(array[y,x]);
                }
                Console.WriteLine();
            }*/

            //2차원 배열
            //각 행과 열의 합을 따로 출력
            //1~9
            //x축 123, 456, 789 합
            //y축 147, 258, 369 합

            /*int[,] array =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9}
            };*/

            // 각 행과 열의 길이를 받아오는 함수
            /*int y = array.GetLength(0);
            int x = array.GetLength(1);

            for(int i =0; i<y; i++)
            {
                int rowSum = 0;
                for(int j = 0; j<x; j++ )
                {
                    rowSum += array[i, j];
                }
                Console.WriteLine($"행의 합: {rowSum}");
            }
            Console.WriteLine("---------------");
            for(int j=0; j<x; j++)
            {
                int colSum = 0;
                for(int i=0; i<y; i++)
                {
                    colSum += array[i, j];
                }
                Console.WriteLine($"열의 합: {colSum}");
            }*/

            //2차원 배열
            //행의 길이는 2, 열의 길이는 3
            //1~6까의 숫자를 행과 열을 구분해서 출력

            int[,] array =
            {
                {1, 2, 3 },
                {4, 5, 6 },
            };

            int y = array.GetLength(0);
            int x = array.GetLength(1);

            for (int i = 0; i < y; i++)
            {
                int row = 0;
                for (int j = 0; j < y; j++)
                {
                    row = array[i, j];
                }
                Console.WriteLine($"행: {row}");
            }


        }
    }
}