using System;

namespace Zmey
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point p1 = new Point(1,1,'$');
            
            Point p2 = new Point(4,4,'%');

            Point p3 = new Point();

            p1.Draw();
            p2.Draw();

            Point p4 = new Point();

            Console.Read();
        }
    }
}
