using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Zmey
{
    class Vertline
    {
        List<Point> Vpoint;

        public Vertline (int xn, int yn, int yf, char summ)
        {
            Vpoint = new List<Point>();

            for (int y=yn; y<=yf; y++)
            {
                Point p = new Point(xn, y, summ);
                Vpoint.Add(p);
            }
        }
        public void Painter ()
        {
            foreach (Point p in Vpoint)
                {
                p.Draw();
            }
            }
        }
 }

