using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Zmey
{
    class HorLine
    {
        List<Point> pList;

        public HorLine(int xl, int xr, int y, char symv)
        {
            pList = new List<Point>( );
              for (int x=xl; x <=xr; x++ )
            {
                Point p = new Point(x, y, symv);
                pList.Add(p);
            }
        }
        public void Drow()
        { 
            foreach(Point p in pList)
           {
                p.Draw();
            
           }

        }
    }
}
