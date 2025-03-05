using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250305_11
{
    //부모클래스 (기본유닛)
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이(가) 기본 공격을 합니다.");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}이 치료할 수 없습니다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    //Garen
    class Garen : Unit
    {
        public Garen()
        {
            Name = "가렌";
            Health = 690;
        }
        public override void Attack()
        {
            Console.WriteLine("가렌이 검으로 공격합니다.");
        }

        public override void Move()
        {
            Console.WriteLine("가렌이 빠르게 움직입니다.");
        }
    }

    //Soraka
    class Soraka : Unit
    {
        public Soraka()
        {
            Name = "소라카";
            Health = 605;
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"소라카가 {target.Name}을 치료합니다.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            units.Add(new Garen());
            units.Add(new Soraka());

            //모든 유닛을 순회하며 다형성 적용
            foreach(var unit in units)
            {
                unit.Move();
                unit.Attack();
                Console.WriteLine();
            }

            //Soraka가 Garen 치료시도
            Soraka soraka = new Soraka();

            soraka.Heal(units[0]);  //가렌을 치료

        }
    }
}
