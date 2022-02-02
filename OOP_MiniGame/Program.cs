using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MiniGame
{
    class Program
    {
        static bool gameOver = false;
        static void Main(string[] args)
        {
            Player player = new Player();
            Map map = new Map();
            while (!gameOver)
            {
                player.Move();
                map.Draw(player.x, player.y, player.avatar);
            }
        }
    }
}
