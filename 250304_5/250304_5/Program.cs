using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250304_5
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }

    }

    public class Strength : Warrior
    {
        public int Strong { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            Strength warrior = new Strength();
            warrior.Name = "워리어";
            warrior.Score = 30;
            warrior.Strong = 10;

            Console.WriteLine($"NAME: {warrior.Name}, SCORE: {warrior.Score}, STRENGTH: {warrior.Strong}");

        }
    }
}
