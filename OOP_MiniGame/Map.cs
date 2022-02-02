using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MiniGame
{
    class Map
    {
        private int previousX;
        private int previousY;
        public void Draw(int x, int y, char avatar)
        {
            Console.SetCursorPosition(previousX, previousY);
            Console.Write(' ');
            Console.SetCursorPosition(x, y);
            Console.Write(avatar);
            previousX = x;
            previousY = y;
        }
    }
}
