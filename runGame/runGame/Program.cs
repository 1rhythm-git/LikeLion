using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace runGame
{
    class Program
    {
        static int playerX = 5, playerY = 5; // 플레이어 위치
        static int groundY = 10; // 땅 높이
        static bool isJumping = false;
        static int jumpHeight = 3;
        static int jumpProgress = 0;
        static int score = 0;
        static bool gameOver = false;
        static char[,] map = new char[20, 40]; // 게임 화면
        static Random rand = new Random();

        static void Main()
        {
            Console.CursorVisible = false;
            Thread gameThread = new Thread(GameLoop);
            gameThread.Start();

            while (!gameOver)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Spacebar && !isJumping)
                    {
                        isJumping = true;
                        jumpProgress = 0;
                    }
                }
            }

            Console.SetCursorPosition(10, 12);
            Console.WriteLine("Game Over! Score: " + score);
            Console.SetCursorPosition(10, 13);
        }

        static void GameLoop()
        {
            while (!gameOver)
            {
                Update();
                Draw();
                Thread.Sleep(100);
            }
        }

        static void Update()
        {
            // 점프 로직
            if (isJumping)
            {
                if (jumpProgress < jumpHeight)
                {
                    playerY--;
                    jumpProgress++;
                }
                else if (jumpProgress < jumpHeight * 2)
                {
                    playerY++;
                    jumpProgress++;
                }
                else
                {
                    isJumping = false;
                }
            }
            else
            {
                playerY = groundY - 1; // 기본 위치
            }

            MoveObjects();
            CheckCollision();
        }

        static void MoveObjects()
        {
            // 장애물과 코인 이동
            for (int x = 1; x < map.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    map[y, x - 1] = map[y, x];
                }
            }

            // 새로운 장애물 또는 코인 생성
            int randValue = rand.Next(10);
            if (randValue < 2)
                map[groundY - 1, map.GetLength(1) - 2] = 'O'; // 장애물
            else if (randValue < 4)
                map[groundY - 2, map.GetLength(1) - 2] = '$'; // 코인
            else
                map[groundY - 1, map.GetLength(1) - 2] = ' ';
        }

        static void CheckCollision()
        {
            if (map[playerY, playerX] == 'O')
            {
                gameOver = true;
            }
            else if (map[playerY, playerX] == '$')
            {
                score += 10;
                map[playerY, playerX] = ' '; // 코인 획득 후 제거
            }
        }

        static void Draw()
        {
            Console.Clear();

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (x == playerX && y == playerY)
                        Console.Write('P'); // 플레이어
                    else
                        Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Score: {score}");
        }
    }
}