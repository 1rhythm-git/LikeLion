using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
            Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.Clear();
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
            Console.WriteLine("┃                             모험가키우기 II                                 ┃");
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
            Console.WriteLine("Loading...");
            for (int x=0; x<=78; x++)
            {
                Console.SetCursorPosition(x, 22);
                Console.WriteLine("■");
                Thread.Sleep(100);
            }


            Thread.Sleep(3000);

            Console.Clear();

            string name;
            Console.Write("모험가 이름을 입력하세요 : ");
            name = Console.ReadLine();
            Thread.Sleep(500);
            


            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine(" ⚔️ 모험가 키우기 II ⚔️");
                Console.WriteLine($"\n[{name}]  💪: {health} | 💰: {gold} | ⚔️: {power}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1. [🏕️] 탐험하기 ");
                Console.WriteLine("2. [🎲] 장비 뽑기 '+1000골드'");
                Console.WriteLine("3. [💤] 휴식하기  '+체력20'");
                Console.WriteLine("4. [🔚] 게임 종료");
                Console.WriteLine("-----------------------------------------------");
                Console.Write(" 입력: ");
                

                input = int.Parse(Console.ReadLine());
                
                if (input == 1)   //1. 탐험하기
                {
                    Console.Clear();                    
                    Console.WriteLine(" 탐험을 시작합니다.");
                    for (int x = 0; x < 20; x++)
                    {
                        Console.SetCursorPosition(x, 2);
                        Console.WriteLine("🚶‍♀️‍➡️");
                        Thread.Sleep(100);
                    }                    

                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"\n 몬스터를 만났습니다! \n [🧌🧌🧌] (체력 -{damage})");
                        health -= damage;
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(100, 301);
                        Console.WriteLine($"\n 보물을 발견했습니다! \n [💰] (+{reward}) 골드");
                        gold += reward;
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);  //10~30 체력 회복
                        Console.WriteLine($"\n 신비한 약초를 발견했습니다! \n [🌿] (+{heal}) 체력");
                        health += heal;
                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("\n 체력이 0이 되어 사망했습니다... \n [💀] GAME OVER!");
                        isAlive = false;
                    }
                    Thread.Sleep(1000);

                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();                        
                        Console.WriteLine(" 장비를 뽑습니다...🎲");
                        Thread.Sleep(500);
                        Console.WriteLine(" 장비를 뽑습니다...🎲🎲");
                        Thread.Sleep(500);
                        Console.WriteLine(" 장비를 뽑습니다...🎲🎲🎲");
                        Thread.Sleep(500);
                        Console.WriteLine(" 장비를 뽑습니다...🎲🎲🎲🎲");
                        Thread.Sleep(500);                        

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine("\n [🗡️] SSS급 전설의 검 (공격력 +50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("\n [🗡️] SS급 희귀한 검 (공격력 +30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("\n [🗡️] S급 강철의 검 (공격력 +20) 획득!");
                            power += 10;
                        }
                        else
                        {
                            Console.WriteLine("\n [🗡️] 녹슨칼 (공격력 +5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (1000 골드 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)  //휴식하기
                {
                    Console.Clear();
                    Console.WriteLine(" 휴식을 취합니다...💤");
                    Thread.Sleep(500);
                    Console.WriteLine(" 휴식을 취합니다...💤💤");
                    Thread.Sleep(500);
                    Console.WriteLine(" 휴식을 취합니다...💤💤💤");
                    Thread.Sleep(500);
                    Console.WriteLine(" 휴식을 취합니다...💤💤💤💤\n\n '💊+20 체력 회복!'");
                    Thread.Sleep(500);
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4)  //종료하기
                {
                    Console.WriteLine("GAME OVER");
                    Environment.Exit(0);
                }
                
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);                    
                }

            }
            
        }
    }
}
