using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TEXTRPG
{
    public class Monster
    {
        public INFO monster;    //몬스터 데이터
        public void SetDamage(int Attack)
        {
            monster.Hp -= Attack;
        }

        //INFO 클래스 타입 인자로 몬스터 데이터를 넣어준다.
        public void SetMonster(INFO tMonster)
        {
            monster = tMonster;
        }

        public INFO GetMonster()
        {
            return monster;
        }

        public void Render()
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"몬스터 이름: {monster.strName}");
            Console.WriteLine($"체력: {monster.Hp}\t공격력: {monster.Attack}");
        }




    }
}
