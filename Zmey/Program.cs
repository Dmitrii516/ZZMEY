using System;

namespace Zmey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 1;
            p1.sym = '#';

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 4;
            p2.sym = '$';

            p1.Draw();
            p2.Draw();

     
            static void Draw(int x, int y, char sym)
            {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            }
     
            Console.Read();
        }
    }
}
