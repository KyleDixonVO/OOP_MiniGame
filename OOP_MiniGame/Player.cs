using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MiniGame
{
    class Player
    {
        public char avatar = '@';
        public int x = 0;
        public int y = 0;

        public Tuple<int, int> Move()
        {
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.W)
            {
                y--;
            }
            if (input == ConsoleKey.S)
            {
                y++;
            }
            if (input == ConsoleKey.A)
            {
                x--;
            }
            if (input == ConsoleKey.D)
            {
                x++;
            }
            return Tuple.Create(x,y);
        }
    }
}
