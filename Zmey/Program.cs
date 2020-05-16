using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Zmey
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point p1 = new Point(1,1,'$');
            
            Point p2 = new Point(4,4,'%');

            Point p3 = new Point(34,32,'q');

            p1.Draw();
            p2.Draw();
            p3.Draw();

            HorLine line = new HorLine(12,22,12,'@');
            line.Drow();
           
                           

            Console.Read();
        }
    }
}
