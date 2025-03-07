using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TEXTRPG
{
    public class Player
    {
        public INFO Info;

        //데미지를 입는 함수
        public void SetDamage(int Attack) 
        { 
            Info.Hp -= Attack;
        }

        //플레이어 정보를 외부에서 볼 수 있는 함수
        public INFO GetInfo() { return Info; }

        //hp를 재설정 해주는 함수
        public void SetHp(int Hp) { Info.Hp = Hp; }

        //직업선택
        public void SelectJob()
        {
            Info = new INFO();
            Console.WriteLine("직업을 선택하세요 (1.기사 2.마법사 3.도둑) : ");
            int Input = 0;

            Input = int.Parse(Console.ReadLine());

            switch(Input)
            {
                case 1:
                    Info.strName = "기사";
                    Info.Hp = 100;
                    Info.Attack = 10;
                    break;
                case 2:
                    Info.strName = "마법사";
                    Info.Hp = 90;
                    Info.Attack = 15;
                    break;
                case 3:
                    Info.strName = "도둑";
                    Info.Hp = 84;
                    Info.Attack = 13;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"직업이름: {Info.strName}");
            Console.WriteLine( $"체력: {Info.Hp}, 공격력: {Info.Attack}");
        }

    }
}
