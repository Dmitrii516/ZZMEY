using System;
using System.Collections.Generic;
using System.Text;

namespace Zmey
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
