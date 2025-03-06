using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Field
    {
        Player player = null;
        Monster monster = null;

        public void SetPlayer(ref Player player1)
        {
            player = player1;
        }

        public void Progress()
        {
            //사냥터 진입
            int Input = 0;

            while(true)
            {
                Console.Clear();
                player.Render();
                DrawMap();

                Input = int.Parse(Console.ReadLine());

                if (Input == 4)
                    break;

                if(Input <= 3)
                {
                    CreateMonster(Input);
                    Fight();
                }
            }
        }

        public void Create(string _strName, int _Hp, int _Attack, out Monster monster1)
        {
            monster1 = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.Hp = _Hp;
            tMonster.Attack = _Attack;

            monster1.SetMonster(tMonster);
        }

        public void CreateMonster(int Input)
        {
            switch(Input)
            {
                case 1:
                    Create("슬라임(초보맵)", 30, 3, out monster);
                    break;
                case 2:
                    Create("고블린(중급맵)", 60, 6, out monster);
                    break;
                case 3:
                    Create("오크 전사(고급맵)", 90, 9, out monster);
                    break;
            }
        }
        public void Fight()
        {
            int Input = 0;
            while(true)
            {
                Console.Clear();
                player.Render();
                monster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                Input = int.Parse(Console.ReadLine());

                if(Input == 1)
                {
                    player.SetDamage(monster.GetMonster().Attack);
                    monster.SetDamage(player.GetInfo().Attack);
                    if(player.GetInfo().Hp <=0)
                    {
                        player.SetHp(100);
                        break;
                    }
                }
                if(Input ==2 || monster.GetMonster().Hp <=0)
                {
                    monster = null;
                    break;
                }

            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("==============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
