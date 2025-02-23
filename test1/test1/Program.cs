using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {

            float Ruin = 0.0f;
            float Card_Guage = 0.0f;
            float Awake = 0.0f;
            int Max_Mana;
            int B_MPR;
            int NB_MPR;
            float Move = 0.0f;
            float Ride = 0.0f;
            float Wagon = 0.0f;
            float Cd = 0.0f;

            Console.Write("루인 스킬 피해: ");
            Ruin = float.Parse(Console.ReadLine());
            Console.Write("카드 게이지: ");
            Card_Guage = float.Parse(Console.ReadLine());
            Console.Write("각성기: ");
            Awake = float.Parse(Console.ReadLine());
            Console.Write("최대 마나: ");
            Max_Mana = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복: ");
            B_MPR = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복: ");
            NB_MPR = int.Parse(Console.ReadLine());
            Console.Write("이동속도: ");
            Move = float.Parse(Console.ReadLine());
            Console.Write("탈것속도: ");
            Ride = float.Parse(Console.ReadLine());
            Console.Write("운반속도: ");
            Wagon = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소: ");
            Cd = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"루인 스킬 피해: {Ruin}%");
            Console.WriteLine($"카드 게이지: {Card_Guage}%");
            Console.WriteLine($"각성기: {Awake}%");
            Console.WriteLine($"최대 마나: {Max_Mana}");
            Console.WriteLine($"전투 중 마나 회복: {B_MPR}");
            Console.WriteLine($"비전투 중 마나 회복: {NB_MPR}");
            Console.WriteLine($"이동속도: {Move}%");
            Console.WriteLine($"탈것속도: {Ride}%");
            Console.WriteLine($"운반속도: {Wagon}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소: {Cd}%");


        }
    }
}
