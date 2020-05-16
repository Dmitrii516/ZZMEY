using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Zmey
{
    class Program
    {
        
        static void Main(string[] args)
        { //Console.SetBufferSize(88, 36);
            Console.WriteLine("Hello World!");

           

            Point p1 = new Point(1,1,'$');
            
            Point p2 = new Point(4,4,'%');

            Point p3 = new Point(34,32,'q');

            p1.Draw();
            p2.Draw();
            p3.Draw();

            HorLine line = new HorLine(0,71,0,'@');
            line.Drow();

            HorLine line11 = new HorLine(0, 71, 23, '@');
            line11.Drow();

            Vertline line2 = new Vertline(0, 0, 23, '@');
            line2.Painter();

            Vertline line22 = new Vertline(71, 0, 23, '@');
            line22.Painter();

            Console.Read();
        }
    }
}
