using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class MainGame
    {
        public Player player = null;
        public Field field = null;

        public void Initialize()
        {
            player = new Player();
            player.SelectJob();
        }

        public void Progress()
        {
            int Input = 0;

            while(true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1.사냥터 2.종료");
                Input = int.Parse(Console.ReadLine());

                if (Input == 2)
                    break;

                if(Input == 1)
                {
                    if(field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref player);
                    }
                    field.Progress();
                }

            }

        }
    }
}
